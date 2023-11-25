using Commun;
using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace Api_Empopasto.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo del inicio de sesion
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IniciarSesionController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IIniciarSesionService objService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_mapper"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public IniciarSesionController(IIniciarSesionService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para iniciar sesion
        /// </summary>
        /// <param name="authModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("IniciarSesion")]
        public async Task<IActionResult> InicioSesionAsync([FromBody] UsuarioFiltroDto loginModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ValidarLogin(loginModel);

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
        }
    }
}
