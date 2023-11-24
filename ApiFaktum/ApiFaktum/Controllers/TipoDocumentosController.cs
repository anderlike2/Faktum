using AutoMapper;
using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

namespace Api_Empopasto.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentosController : ControllerBase
    {
        private readonly ICreateLogger createLogger;
        private readonly ITipoDocumentoService _objService;
        private readonly IMapper mapper;

        public TipoDocumentosController(ITipoDocumentoService objService, IMapper _mapper, ICreateLogger _createLogger)
        {
            _objService = objService;
            this.mapper = _mapper;
            this.createLogger = _createLogger;
        }              

        [HttpGet(nameof(GetAllTipoDocumentos))]
        public Result GetAllTipoDocumentos()
        {
            Result oRespuesta = new Result();

            try
            {
                var queryTable = _objService.GetAll();

                var lstTemp = mapper.Map<List<TipoDocumentoDto>>(queryTable.Result.Data);

                if (lstTemp.Count >= 0)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Data = lstTemp;
                }
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);

                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }       
    }
}
