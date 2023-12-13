using Commun.Logger;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo de la tabla ciudad
    /// </summary>
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly ICiudadService objService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public CiudadController(ICiudadService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la ciudades de un departamento
        /// </summary>
        /// <param name="idDepto"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarCiudadesDepto")]
        public async Task<IActionResult> ConsultarCiudadesDepto(int idDepto)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarCiudadesDepto(idDepto);

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
