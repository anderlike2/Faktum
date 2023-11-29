using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class IniciarSesionService : IIniciarSesionService
    {
        private readonly IUsuarioRepository objUsuarioRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUsuarioRepository"></param>
        /// <returns></returns>
        public IniciarSesionService(IUsuarioRepository _objUsuarioRepository)
        {
            this.objUsuarioRepository = _objUsuarioRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ValidarLogin(UsuarioFiltroDto objModel)
        {
            Result oRespuesta = new Result();

            Task<Result> informacionUsuario = objUsuarioRepository.ConsultarUsuario(objModel);
            UsuarioDto usuarioCompleto = (UsuarioDto)informacionUsuario.Result.Data;

            if (usuarioCompleto == null)
            {
                Task<Result> existeUsuario = objUsuarioRepository.ConsultarUsuarioPorUsername(objModel.UsuaUsuario);
                UsuarioDto usuarioUsername = (UsuarioDto)existeUsuario.Result.Data;              

                if (usuarioUsername == null)
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = Constantes.msjUsuarioNoExiste;
                }
                else
                {
                    if (usuarioUsername.UsuaIntentos == int.Parse(Constantes.IntentosInicioSesion))
                    {
                        oRespuesta.Success = false;
                        oRespuesta.Message = Constantes.msjUsuarioBloqueado;
                        return oRespuesta;
                    }

                    if ((int.Parse(Constantes.IntentosInicioSesion) - 1) == usuarioUsername.UsuaIntentos)
                    {
                        oRespuesta.Success = false;
                        oRespuesta.Message = Constantes.msjUsuarioBloqueado;

                        //Actualizacion de estado a bloqueado
                        usuarioUsername.UsuaIntentos = usuarioUsername.UsuaIntentos + 1;
                        usuarioUsername.Estado = 0;
                        
                    }
                    else
                    {
                        string mensajeAdvertencia = Constantes.msjLoginErrado.Replace("{a}", (int.Parse(Constantes.IntentosInicioSesion) - (usuarioUsername.UsuaIntentos + 1)).ToString());
                        oRespuesta.Success = false;
                        oRespuesta.Message = mensajeAdvertencia;

                        //Actualizacion de estado a 1 fallido
                        usuarioUsername.UsuaIntentos = usuarioUsername.UsuaIntentos + 1;
                    }
                    await objUsuarioRepository.ActualizarUsuario(usuarioUsername);
                }
                return oRespuesta;
            }
            else
            {
                if(usuarioCompleto.UsuaIntentos == int.Parse(Constantes.IntentosInicioSesion))
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = Constantes.msjUsuarioBloqueado;
                    return oRespuesta;
                }
                //Actualizacion de estado activo
                usuarioCompleto.UsuaIntentos = 0;
                usuarioCompleto.Estado = 1;
                await objUsuarioRepository.ActualizarUsuario(usuarioCompleto);
            }
            return informacionUsuario.Result;
        }
    }
}
