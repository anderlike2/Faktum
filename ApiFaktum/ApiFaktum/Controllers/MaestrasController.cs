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
    [Authorize]
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla NumeracionResolucion
        /// </summary>
        /// <returns>Task<Result></returns>
        [HttpGet]
        [Route("ConsultarTablaNumeracionResolucion")]
        public async Task<IActionResult> ConsultarTablaNumeracionResolucion()
        {
            Result oRespuesta = new();

            try
            {
                var vRespuesta = await objService.ConsultarTablaNumeracionResolucion();

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
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

                if (vRespuesta.Success)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                    oRespuesta.Data = vRespuesta.Data;

                    return Ok(oRespuesta);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = vRespuesta.Message;

                    return Ok(oRespuesta);
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);
                oRespuesta.Message = ex.Message;

                return BadRequest();
            }
        }
    }
}
