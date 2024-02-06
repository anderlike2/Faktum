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
    public class OtroServicioRipsController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IOtroServicioRipsService objService;

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public OtroServicioRipsController(IOtroServicioRipsService _objService, ICreateLogger _createLogger)
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
        [Route("ConsultarOtroServicioRips")]
        public async Task<IActionResult> ConsultarOtroServicioRips()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarOtroServicioRips();

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
        [Route("CrearOtroServicioRips")]
        public async Task<IActionResult> CrearOtroServicioRips([FromBody] OtroServicioRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearOtroServicioRips(objModel);

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
        [Route("ActualizarOtroServicioRips")]
        public async Task<IActionResult> ActualizarOtroServicioRips([FromBody] OtroServicioRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarOtroServicioRips(objModel);

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
        [Route("EliminarOtroServicioRips")]
        public async Task<IActionResult> EliminarOtroServicioRips([FromBody] OtroServicioRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarOtroServicioRips(objModel);

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
