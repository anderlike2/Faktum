using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo de los formatos de impresion
    /// </summary>
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FormatoImpresionController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IFormatoImpresionService objService;
        private readonly IValidacionesService objValidacionesService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <param name="_objValidacionesService"></param>
        /// <returns></returns>
        public FormatoImpresionController(IFormatoImpresionService _objService, ICreateLogger _createLogger, IValidacionesService _objValidacionesService)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
            this.objValidacionesService = _objValidacionesService;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los formatos de impresion por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarFormatosImpresionEmpresa")]
        public async Task<IActionResult> ConsultarFormatosImpresionEmpresa(int idEmpresa)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarFormatosImpresionEmpresa(idEmpresa);

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message + " - Inner: " + ex.InnerException;
            }
            return Ok(oRespuesta);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("CrearFormatoImpresion")]
        public async Task<IActionResult> CrearFormatoImpresion([FromBody] FormatoImpresionDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearFormatoImpresion(objModel);

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message + " - Inner: " + ex.InnerException;
            }
            return Ok(oRespuesta);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("ActualizarFormatoImpresion")]
        public async Task<IActionResult> ActualizarFormatoImpresion([FromBody] FormatoImpresionDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarFormatoImpresion(objModel);

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message + " - Inner: " + ex.InnerException;
            }
            return Ok(oRespuesta);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("EliminarFormatoImpresion")]
        public async Task<IActionResult> EliminarFormatoImpresion([FromBody] FormatoImpresionDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarFormatoImpresion(objModel);

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = objValidacionesService.ValidarEliminacionRegistro(ex);
            }
            return Ok(oRespuesta);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el formato de impresion por id
        /// </summary>
        /// <param name="idFormatoImpresion"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarFormatoImpresionId")]
        public async Task<IActionResult> ConsultarFormatoImpresionId(int idFormatoImpresion)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarFormatoImpresionId(idFormatoImpresion);

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message + " - Inner: " + ex.InnerException;
            }
            return Ok(oRespuesta);
        }
    }
}
