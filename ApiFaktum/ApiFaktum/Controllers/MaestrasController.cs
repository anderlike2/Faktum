using Commun.Logger;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo de las tablas maestras
    /// </summary>
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MaestrasController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IMaestrasService objService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public MaestrasController(IMaestrasService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para iniciar sesion
        /// </summary>
        /// <param name="tipoClase"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaMaestra")]
        public async Task<IActionResult> ConsultarTablaMaestra(string tipoClase)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaMaestra(tipoClase);

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
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
