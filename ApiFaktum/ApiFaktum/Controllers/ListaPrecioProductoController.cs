using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace ApiFaktum.Controllers
{
    /// <summary>
    /// Anderson Benavides
    /// Controlador para el manejo de la tabla sucursal
    /// </summary>
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ListaPrecioProductoController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly IListaPrecioProductoService objService;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objService"></param>
        /// <param name="_createLogger"></param>
        /// <returns></returns>
        public ListaPrecioProductoController(IListaPrecioProductoService _objService, ICreateLogger _createLogger)
        {
            this.objService = _objService;
            this.createLogger = _createLogger;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("CrearListaPrecioProducto")]
        public async Task<IActionResult> CrearListaPrecioProducto([FromBody] ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.CrearListaPrecioProducto(objModel);

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
        /// Metodo para actualizar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("ActualizarListaPrecioProducto")]
        public async Task<IActionResult> ActualizarListaPrecioProducto([FromBody] ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ActualizarListaPrecioProducto(objModel);

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
        /// Metodo para consultar los productos por lista de precios
        /// </summary>
        /// <param name="idListaPrecio"></param>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarProductosListaPrecioId")]
        public async Task<IActionResult> ConsultarProductosListaPrecioId(int idListaPrecio)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarProductosListaPrecioId(idListaPrecio);

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
        /// Metodo para eliminar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        [HttpPost]
        [Route("EliminarListaPrecioProducto")]
        public async Task<IActionResult> EliminarListaPrecioProducto([FromBody] ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.EliminarListaPrecioProducto(objModel);

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
