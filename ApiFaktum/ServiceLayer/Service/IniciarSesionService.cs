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
        private readonly IRolRepository objRolRepository;
        private readonly IEmpresaRepository objEmpresaRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUsuarioRepository"></param>
        /// <param name="_objRolRepository"></param>
        /// <returns></returns>
        public IniciarSesionService(IUsuarioRepository _objUsuarioRepository, IRolRepository _objRolRepository, IEmpresaRepository _objEmpresaRepository)
        {
            this.objUsuarioRepository = _objUsuarioRepository;
            this.objRolRepository = _objRolRepository;
            this.objEmpresaRepository = _objEmpresaRepository;
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

                    oRespuesta = ValidarPasswordUsuarioExistente(usuarioUsername).Result;
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

            //Consultar los perfiles
            return ConsultarEmpresasRolesUsuario(usuarioCompleto).Result;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el informacion de un ususario con error de password
        /// </summary>
        /// <param name="usuarioUsername"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ValidarPasswordUsuarioExistente(UsuarioDto usuarioUsername)
        {
            Result oRespuesta = new Result();
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
            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar empresas y roles de la empresa
        /// </summary>
        /// <param name="usuarioCompleto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarEmpresasRolesUsuario(UsuarioDto usuarioCompleto)
        {
            Result oRespuesta = new Result();
            Task<Result> rolesUsuario = objRolRepository.ConsultarRolesUsuario(usuarioCompleto.Id);
            List<RolDto> roles = (List<RolDto>)rolesUsuario.Result.Data;
            if (roles == null || roles.Count <= 0)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjUsuarioSinRoles;
                return oRespuesta;
            }
            else
            {
                //Validar usuario Administrador o Operativo
                bool esAdministrador = false;
                roles.ForEach(item =>
                {
                    if(item.RolCodigo != null && item.RolCodigo.Equals(Constantes.rolAdministrador))
                        esAdministrador |= true;
                });
                Task<Result> empresasUsuario;
                if (esAdministrador)
                    empresasUsuario = objEmpresaRepository.ConsultarEmpresas();
                else
                    empresasUsuario = objEmpresaRepository.ConsultarEmpresasUsuario(usuarioCompleto.Id);

                List<EmpresaDto> empresas = (List<EmpresaDto>)empresasUsuario.Result.Data;
                if (empresas == null || empresas.Count <= 0)
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = Constantes.msjUsuarioSinEmpresas;
                    return oRespuesta;
                }
                else
                {
                    usuarioCompleto.UsuRoles = roles;
                    usuarioCompleto.UsuEmpresas = empresas;
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                    oRespuesta.Data = usuarioCompleto;
                    return oRespuesta;
                }
            }
        }
    }
}
