using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla resolucion
    /// </summary>
    public class ResolucionRepository : IResolucionRepository
    {
        private readonly ApplicationDbContext objContext;
        private readonly IMapper mapper;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <param name="_mapper"></param>
        /// <returns></returns>
        public ResolucionRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las resoluciones de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarResolucionesEmpresa(int idEmpresa)
        {
            Result oRespuesta = new Result();
            List<ResolucionModel>? lstResult = new List<ResolucionModel>();

            try
            {
                lstResult =
                    await objContext.Resolucion.Where(x => x.Estado == 1 && x.ResoEmpresa.Id.Equals(idEmpresa)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<ResolucionDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ResolucionDto>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearResolucion(ResolucionDto objModel)
        {
            Result oRespuesta = new();
            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<ResolucionModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegGuardado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarResolucion(ResolucionDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<ResolucionModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegActualizado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarResolucion(ResolucionDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.Resolucion.Remove(mapper.Map<ResolucionModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegEliminado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la resolucion por id
        /// </summary>
        /// <param name="idResolucion"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarResolucionId(int idResolucion)
        {
            Result oRespuesta = new Result();
            ResolucionModel? result = new ResolucionModel();

            try
            {
                result =
                    await objContext.Resolucion.FirstOrDefaultAsync(x => x.Id.Equals(idResolucion));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<ResolucionDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ResolucionDto>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las resoluciones de una sucursal
        /// </summary>
        /// <param name="idSucursal"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarResolucionesSucursal(int idSucursal)
        {
            Result oRespuesta = new Result();
            List<ResolucionModel>? lstResult = new List<ResolucionModel>();

            try
            {
                lstResult = await (from resu in objContext.ResolucionSucursal
                                   join res in objContext.Resolucion on resu.ResuResolucion.Id equals res.Id
                                   where resu.ResuSucursal.Id == idSucursal
                                   select new ResolucionModel
                                   {
                                       Id = resu.Id,
                                       ResoAnio = res.ResoAnio,
                                       ResoConsActual = res.ResoConsActual,
                                       ResoConsFinal = res.ResoConsFinal,
                                       ResoConsInicial = res.ResoConsInicial,
                                       ResoEstadoOperacion = res.ResoEstadoOperacion,
                                       ResoFechaExpide = res.ResoFechaExpide,
                                       ResoPrefijo = res.ResoPrefijo,
                                       ResoVigencia = res.ResoVigencia,
                                       ResoCodigo = res.ResoCodigo,
                                       ResoNumeracionActual = res.ResoNumeracionActual
                                   }).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<ResolucionDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ResolucionDto>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }
    }
}
