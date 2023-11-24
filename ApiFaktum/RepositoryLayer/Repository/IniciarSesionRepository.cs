using AutoMapper;
using Commun;
using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;
using static Commun.Enums;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class IniciarSesionRepository : IIniciarSesionRepository
    {
        private readonly ApplicationDbContext objContext;

        private readonly ICreateLogger createLogger;
        private readonly IMapper mapper;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <param name="_mapper"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public IniciarSesionRepository(ApplicationDbContext _objContext, IMapper _mapper, ICreateLogger _createLogger)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ValidarLogin(LoginModel objModel)
        {
            Result oRespuesta = new Result();

            Usuario listResult = new Usuario();
            UsuarioDto lstTemp = new UsuarioDto();

            try
            {
                listResult = await objContext.Usuarios.Where(x => x.Login == objModel.UserName).FirstAsync();

                if (listResult.Id > 0)
                {
                    lstTemp = mapper.Map<UsuarioDto>(listResult);

                    if (listResult.Estado == Convert.ToInt32(Enums.Estado.Anulado))
                    {
                        oRespuesta.Success = false;
                        oRespuesta.Message = Constantes.msjUsuarioEliminado;
                    }
                    else if (listResult.Intentos >= 5)
                    {
                        await BloquearUsuario(objModel);

                        oRespuesta.Success = false;
                        oRespuesta.Message = Constantes.msjUsuarioBloqueado;
                    }
                    else if (listResult.Password != objModel.Password)
                    {
                        var vIntentosTemp = await ActualizarIntentos(objModel, false);

                        oRespuesta.Success = false;

                        if (vIntentosTemp.Message == "4")
                            oRespuesta.Message = "Las credenciales son incorrectas, te queda 1 intento";
                        else
                            oRespuesta.Message = "Las credenciales son incorrectas";
                    }
                    else
                    {
                        oRespuesta.Success = true;
                        oRespuesta.Data = lstTemp;

                        await ActualizarIntentos(objModel, true);
                    }
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = "Las credenciales son incorrectas";
                    oRespuesta.Data = null;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Sequence contains no elements.")
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = "Las credenciales son incorrectas";
                    oRespuesta.Data = null;
                }
                else
                {
                    createLogger.LogWriteExcepcion(ex.Message);

                    oRespuesta.Message = ex.Message;
                }
            }

            return oRespuesta ?? new Result();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar los intentos de inicio de sesion
        /// </summary>
        /// <param name="objModel"></param>
        /// <param name="vCredIncorrecta"></param>
        /// <returns>Task<Result></returns>
        private async Task<Result> ActualizarIntentos(LoginModel objModel, bool vCredIncorrecta)
        {
            Result oRespuesta = new Result();

            Usuario listResult = new Usuario();
            Usuario lstTemp = new Usuario();

            try
            {
                listResult = await objContext.Usuarios.Where(x => x.Login == objModel.UserName).FirstAsync();

                if (listResult.Id > 0)
                {
                    lstTemp = mapper.Map<Usuario>(listResult);

                    if (vCredIncorrecta)
                    {
                        lstTemp.Intentos = 0;
                    }
                    else
                    {
                        lstTemp.Intentos = lstTemp.Intentos + 1;

                        oRespuesta.Message = lstTemp.Intentos.ToString();
                    }

                    objContext.Update(lstTemp);

                    await objContext.SaveChangesAsync();

                    oRespuesta.Success = true;
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);

                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para bloquear el usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        private async Task<Result> BloquearUsuario(LoginModel objModel)
        {
            Result oRespuesta = new Result();

            Usuario listResult = new Usuario();
            Usuario lstTemp = new Usuario();

            try
            {
                listResult = await objContext.Usuarios.Where(x => x.Login == objModel.UserName).FirstAsync();

                if (listResult.Id > 0)
                {
                    lstTemp = mapper.Map<Usuario>(listResult);

                    lstTemp.Estado = (int)Enums.Estado.Inactivo;
                    lstTemp.EstadoClave = (int?)Enums.Estado.Inactivo;

                    objContext.Update(lstTemp);

                    await objContext.SaveChangesAsync();

                    oRespuesta.Success = true;
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);

                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }
    }
}
