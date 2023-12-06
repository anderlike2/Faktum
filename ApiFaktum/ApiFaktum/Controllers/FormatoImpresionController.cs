using Commun.Logger;
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

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public FormatoImpresionController(IFormatoImpresionService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
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
    }
}
