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
    //[Authorize]
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
        /// Metodo para consultar las tablas maestras
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
        /// Metodo para consultar la tabla retefuente
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaRetefuente")]
        public async Task<IActionResult> ConsultarTablaRetefuente()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaRetefuente();

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
        /// Metodo para consultar la tabla cum
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaCum")]
        public async Task<IActionResult> ConsultarTablaCum()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaCum();

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
        /// Metodo para consultar la tabla regimen
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaRegimen")]
        public async Task<IActionResult> ConsultarTablaRegimen()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaRegimen();

                oRespuesta.Success = vRespuesta.Success;
                oRespuesta.Message = vRespuesta.Message;
                oRespuesta.Data = vRespuesta.Data;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Success = false;
                oRespuesta.Message = ex.Message;
            }
            return Ok(oRespuesta);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla ium
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaIum")]
        public async Task<IActionResult> ConsultarTablaIum()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaIum();

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
        /// Metodo para consultar la tabla ClasJuridica
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaClasJuridica")]
        public async Task<IActionResult> ConsultarTablaClasJuridica()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaClasJuridica();

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
        /// Metodo para consultar la tabla Impuesto
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaImpuesto")]
        public async Task<IActionResult> ConsultarTablaImpuesto()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaImpuesto();

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
        /// Metodo para consultar la tabla Ciudad
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaCiudad")]
        public async Task<IActionResult> ConsultarTablaCiudad()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaCiudad();

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
        /// Metodo para consultar la tabla Depto
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaDepto")]
        public async Task<IActionResult> ConsultarTablaDepto()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaDepto();

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
