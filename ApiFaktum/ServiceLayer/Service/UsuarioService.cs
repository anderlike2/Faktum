using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository objUsuarioRepository;
        private readonly IRolRepository objRolRepository;
        private readonly IEmpresaRepository objEmpresaRepository;
        private readonly IUsuarioEmpresaRepository objUsuarioEmpresaRepository;
        private readonly IRolUsuarioRepository objRolUsuarioRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUsuarioRepository"></param>
        /// <param name="_objRolRepository"></param>
        /// <param name="_objEmpresaRepository"></param>
        /// <param name="_objUsuarioEmpresaRepository"></param>
        /// <param name="_objRolUsuarioRepository"></param>
        /// <returns></returns>
        public UsuarioService(IUsuarioRepository _objUsuarioRepository, IRolRepository _objRolRepository, IEmpresaRepository _objEmpresaRepository, 
            IUsuarioEmpresaRepository _objUsuarioEmpresaRepository, IRolUsuarioRepository _objRolUsuarioRepository)
        {
            this.objUsuarioRepository = _objUsuarioRepository;
            this.objRolRepository = _objRolRepository;
            this.objEmpresaRepository = _objEmpresaRepository;
            this.objUsuarioEmpresaRepository = _objUsuarioEmpresaRepository;
            this.objRolUsuarioRepository = _objRolUsuarioRepository;
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
            //byte[] encrypted = ManejoEncriptacion.EncryptAES("Admin1980");
            //string s = System.Text.Encoding.UTF8.GetString(encrypted, 0, encrypted.Length);
            //string y = ManejoEncriptacion.DecryptAES(encrypted);
            //byte[] t1 = ManejoEncriptacion.Encrypt("Admin1980");
            //string t3 = ManejoEncriptacion.Decrypt2(t1);

            //string decryptedText = ManejoEncriptacion.DecryptAES(Encoding.ASCII.GetBytes(objModel.UsuaPassword));

            Result oRespuesta = new Result();

            Task<Result> informacionUsuario = objUsuarioRepository.ConsultarUsuario(objModel);
            UsuarioDto? usuarioCompleto = (UsuarioDto)informacionUsuario.Result.Data;

            if (usuarioCompleto == null)
            {
                Task<Result> existeUsuario = objUsuarioRepository.ConsultarUsuarioPorUsername(objModel.UsuaUsuario);
                UsuarioDto? usuarioUsername = (UsuarioDto)existeUsuario.Result.Data;              

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

            //Consultar la informacion de los roles
            return ConsultarRolesUsuario(usuarioCompleto).Result;
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
        /// Metodo para consultar roles de la empresa
        /// </summary>
        /// <param name="usuarioCompleto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarRolesUsuario(UsuarioDto usuarioCompleto)
        {
            Result oRespuesta = new Result();
            Task<Result>? rolesUsuario = objRolRepository.ConsultarRolesUsuario(usuarioCompleto.Id);
            List<RolDto>? roles = (List<RolDto>)rolesUsuario.Result.Data;
            if (roles == null || roles.Count <= 0)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjUsuarioSinRoles;
                return oRespuesta;
            }
            else
            {
                usuarioCompleto.UsuaRoles = roles;
                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjLoginCorrecto;
                oRespuesta.Data = usuarioCompleto;
                return oRespuesta;
            }
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar empresas de usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarEmpresasUsuario(UsuarioDto objModel)
        {
            Result oRespuesta = new Result();
            Task<Result>? rolesUsuario = objRolRepository.ConsultarRolesUsuario(objModel.Id);
            List<RolDto>? roles = (List<RolDto>)rolesUsuario.Result.Data;

            //Validar usuario Administrador o Operativo
            bool esAdministrador = false;
            roles.ForEach(item =>
            {
                if (item.RolCodigo != null && item.RolCodigo.Equals(Constantes.rolAdministrador))
                    esAdministrador |= true;
            });
            Task<Result> empresasUsuario;
            if (esAdministrador)
                empresasUsuario = objEmpresaRepository.ConsultarEmpresas();
            else
                empresasUsuario = objEmpresaRepository.ConsultarEmpresasUsuario(objModel.Id);

            List<EmpresaDto> empresas = (List<EmpresaDto>)empresasUsuario.Result.Data;
            if (empresas == null || empresas.Count <= 0)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjUsuarioSinEmpresas;
                return oRespuesta;
            }
            else
            {
                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjConsultaExitosa;
                oRespuesta.Data = empresas;
                return oRespuesta;
            }
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearUsuario(UsuarioDto objModel)
        {
            Result oRespuesta = new Result();
            oRespuesta = ValidarInformacionUsuario(objModel);

            if (oRespuesta.Success)
            {
                //Validar el usuario en la empresa
                Task<Result> existeUsuario = objUsuarioRepository.ConsultarUsuarioPorUsername(objModel.UsuaUsuario);
                UsuarioDto? usuarioUsername = (UsuarioDto)existeUsuario.Result.Data;
                if (usuarioUsername == null)
                {
                    Task<Result> usuarioInsertado = objUsuarioRepository.CrearUsuario(objModel);
                    int usuario = (int)usuarioInsertado.Result.Data;
                    if (usuario > 0)
                    {
                        //Se inserta las empresas del usuario
                        EmpresasUsuarioDto refEmpresa = new EmpresasUsuarioDto();
                        refEmpresa.EmusEmpresaId = objModel.UsuaEmpresaId;
                        refEmpresa.EmusUsuarioId = usuario;
                        refEmpresa.Estado = int.Parse(Constantes.estadoActivo);
                        objUsuarioEmpresaRepository.CrearUsuarioEmpresa(refEmpresa);

                        //Se inserta los roles del usuario
                        RolUsuarioDto refRol = new RolUsuarioDto();
                        refRol.RousRolId = objModel.UsuaRolId;
                        refRol.RousUsuarioId = usuario;
                        refRol.Estado = int.Parse(Constantes.estadoActivo);
                        objRolUsuarioRepository.CrearUsuarioRol(refRol);

                        oRespuesta.Success = true;
                        oRespuesta.Message = Constantes.msjRegGuardado;
                        return Task.FromResult(oRespuesta);
                    }
                    else
                    {
                        oRespuesta.Success = false;
                        oRespuesta.Message = Constantes.msjUsuarioNoInsertado;
                        return Task.FromResult(oRespuesta);
                    }
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = Constantes.msjUsuarioYaCreado;
                    return Task.FromResult(oRespuesta);
                }
            }
            else
            {
                return Task.FromResult(oRespuesta);
            }
            
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar informacion del usuario a insertar
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Result ValidarInformacionUsuario(UsuarioDto objModel)
        {
            Result oRespuesta = new Result();
            oRespuesta.Success = true;
            if (!objModel.UsuaPassword.Equals(objModel.UsuaPasswordConfirm))
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjPasswordNoCoincide;
            }
            return oRespuesta;
        }
    }
}
