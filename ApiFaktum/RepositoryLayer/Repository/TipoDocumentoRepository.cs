using AutoMapper;
using Commun;
using Commun.Logger;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;
using System.Data;

namespace RepositoryLayer.Repository
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly ApplicationDbContext objContext;

         private readonly ICreateLogger createLogger;
        private readonly IMapper mapper;

        public TipoDocumentoRepository(ApplicationDbContext _objContext, IMapper _mapper, ICreateLogger _createLogger)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
            this.createLogger = _createLogger;
        }

        public async Task<Result> Delete(TipoDocumentoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                if (objModel == null)
                {
                    throw new ArgumentNullException("entity");
                }

                objModel.Estado = (int)Enums.Estado.Anulado;
                objModel.FechaModificacion = DateTime.UtcNow;

                var lstTemp = mapper.Map<TipoDocumento>(objModel);

                objContext.Update(lstTemp);

                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegEliminado;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);

                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        public async Task<Result> GetAll()
        {
            Result oRespuesta = new Result();

            List<TipoDocumento> listResult = new List<TipoDocumento>();
            List<TipoDocumentoDto> lstTemp = new List<TipoDocumentoDto>();

            try
            {
                listResult = await objContext.TipoDocumentos.Where(x => x.Estado != 2).ToListAsync();

                if (listResult.Count > 0)
                {
                    lstTemp = mapper.Map<List<TipoDocumentoDto>>(listResult);

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

        public async Task<Result> GetById(int Id)
        {
            Result oRespuesta = new Result();

            List<TipoDocumento> listResult = new List<TipoDocumento>();
            List<TipoDocumentoDto> lstTemp = new List<TipoDocumentoDto>();

            try
            {
                listResult = await objContext.TipoDocumentos.Where(x => x.Id == Id && x.Estado != 2).ToListAsync();

                if (listResult.Count > 0)
                {
                    lstTemp = mapper.Map<List<TipoDocumentoDto>>(listResult);

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

        public async Task<Result> Insert(TipoDocumentoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                if (objModel == null)
                {
                    throw new ArgumentNullException("entity");
                }

                objModel.Estado = (int)Enums.Estado.Activo;
                objModel.FechaCreacion = DateTime.UtcNow;

                var lstTemp = mapper.Map<TipoDocumento>(objModel);

                await objContext.AddAsync(lstTemp);

                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegGuardado;
            }
            catch (Exception ex)
            {
                createLogger.LogWriteExcepcion(ex.Message);

                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        public async Task<Result> Update(TipoDocumentoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                if (objModel == null)
                {
                    throw new ArgumentNullException("entity");
                }

                objModel.FechaModificacion = DateTime.UtcNow;

                var lstTemp = mapper.Map<TipoDocumento>(objModel);

                objContext.Update(lstTemp);

                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegActualizado;
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