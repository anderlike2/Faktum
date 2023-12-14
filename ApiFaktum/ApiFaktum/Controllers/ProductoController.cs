using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo de la tabla producto
    /// </summary>
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IProductoService objService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public ProductoController(IProductoService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarProductosEmpresa")]
        public async Task<IActionResult> ConsultarProductosEmpresa(int idEmpresa)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarProductosEmpresa(idEmpresa);

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
        /// Metodo para crear los productos
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("CrearProducto")]
        public async Task<IActionResult> CrearProducto([FromBody] ProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearProducto(objModel);

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
        /// Metodo para actualizar los productos
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("ActualizarProducto")]
        public async Task<IActionResult> ActualizarProducto([FromBody] ProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarProducto(objModel);

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
        /// Metodo para eliminar los productos
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("EliminarProducto")]
        public async Task<IActionResult> EliminarProducto([FromBody] ProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarProducto(objModel);

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
        /// Metodo para consultar un producto por id
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarProductoId")]
        public async Task<IActionResult> ConsultarProductoId(int idProducto)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarProductoId(idProducto);

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
