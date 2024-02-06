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
    public class MedicamentosRipsController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IMedicamentosRipsService objService;

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public MedicamentosRipsController(IMedicamentosRipsService _objService, ICreateLogger _createLogger)
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
        [Route("ConsultarMedicamentosRips")]
        public async Task<IActionResult> ConsultarMedicamentosRips()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarMedicamentosRips();

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
        [Route("CrearMedicamentosRips")]
        public async Task<IActionResult> CrearMedicamentosRips([FromBody] MedicamentosRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearMedicamentosRips(objModel);

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
        [Route("ActualizarMedicamentosRips")]
        public async Task<IActionResult> ActualizarMedicamentosRips([FromBody] MedicamentosRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarMedicamentosRips(objModel);

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
        [Route("EliminarMedicamentosRips")]
        public async Task<IActionResult> EliminarMedicamentosRips([FromBody] MedicamentosRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarMedicamentosRips(objModel);

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
