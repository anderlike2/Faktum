using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext objContext;
        private readonly IMapper mapper;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <param name="_mapper"></param>
        /// <returns></returns>
        public UsuarioRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUsuario(UsuarioFiltroDto objModel)
        {
            Result oRespuesta = new Result();

            UsuarioModel? result = new UsuarioModel();
            UsuarioDto temp = new UsuarioDto();

            try
            {
                result = await objContext.Usuario.AsNoTracking().Where(x => x.UsuaUsuario.Equals(objModel.UsuaUsuario) && x.UsuaPassword.Equals(objModel.UsuaPassword)).Include(z => z.UsuEmpresa).FirstAsync();

                if (result != null)
                {
                    temp = mapper.Map<UsuarioDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el usuario por username
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUsuarioPorUsername(string username)
        {
            Result oRespuesta = new Result();

            UsuarioModel? result = new UsuarioModel();
            UsuarioDto temp = new UsuarioDto();

            try
            {
                result = await objContext.Usuario.AsNoTracking().Where(x => x.UsuaUsuario.Equals(username)).FirstAsync();

                if (result != null)
                {
                    temp = mapper.Map<UsuarioDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar informacion de un usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarUsuario(UsuarioDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                var objTemp = mapper.Map<UsuarioModel>(objModel);
                objTemp.FechaModificacion = DateTime.UtcNow;

                objContext.Update(objTemp);
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return oRespuesta;
        }
    }
}
