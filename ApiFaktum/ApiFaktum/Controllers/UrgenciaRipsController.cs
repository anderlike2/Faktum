using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Sebastian Cardona
    /// Controlador para el manejo de la tabla sucursal
    /// </summary>
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UrgenciaRipsController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IUrgenciaRipsService objService;

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public UrgenciaRipsController(IUrgenciaRipsService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes por empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarUrgenciaRips")]
        public async Task<IActionResult> ConsultarUrgenciaRips()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarUrgenciaRips();

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
        /// Sebastian Cardona
        /// Metodo para crear los UsuariosSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("CrearUrgenciaRips")]
        public async Task<IActionResult> CrearUrgenciaRips([FromBody] UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearUrgenciaRips(objModel);

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
        /// Metodo para actualizar los clientes
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("ActualizarUrgenciaRips")]
        public async Task<IActionResult> ActualizarUrgenciaRips([FromBody] UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarUrgenciaRips(objModel);

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
        /// Metodo para eliminar las sucursales
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("EliminarUrgenciaRips")]
        public async Task<IActionResult> EliminarUrgenciaRips([FromBody] UrgenciaRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarUrgenciaRips(objModel);

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
