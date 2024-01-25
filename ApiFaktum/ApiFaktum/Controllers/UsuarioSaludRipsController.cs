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
    public class UsuarioSaludRipsController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IUsuarioSaludRipsService objService;

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public UsuarioSaludRipsController(IUsuarioSaludRipsService _objService, ICreateLogger _createLogger)
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
        [Route("ConsultarUsuarioSaludRips")]
        public async Task<IActionResult> ConsultarUsuarioSaludRips()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarUsuarioSaludRips();

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
[Route("CrearUsuarioSaludRips")]
public async Task<IActionResult> CrearUsuarioSaludRips([FromBody] UsuarioSaludRipsDto objModel)
{
    Result oRespuesta = new();

    try
    {
        var vRespuesta = await objService.CrearUsuarioSaludRips(objModel);

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
        [Route("ActualizarUsuarioSaludRips")]
        public async Task<IActionResult> ActualizarUsuarioSaludRips([FromBody] UsuarioSaludRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarUsuarioSaludRips(objModel);

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
        [Route("EliminarUsuarioSaludRips")]
        public async Task<IActionResult> EliminarUsuarioSaludRips([FromBody] UsuarioSaludRipsDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarUsuarioSaludRips(objModel);

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