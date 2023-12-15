using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla unidad
    /// </summary>
    public class UnidadRepository : IUnidadRepository
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
        public UnidadRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las unidades por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUnidadesEmpresa(int idEmpresa)
        {
            Result oRespuesta = new Result();
            List<UnidadModel>? lstResult = new List<UnidadModel>();

            try
            {
                lstResult =
                    await objContext.Unidad.Where(x => x.Estado == 1 && x.UnidEmpresa.Id.Equals(idEmpresa)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<UnidadDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<UnidadDto>();
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
        /// Metodo para crear una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearUnidad(UnidadDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<UnidadModel>(objModel));
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
        /// Metodo para actualizar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarUnidad(UnidadDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<UnidadModel>(objModel));
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
        /// Metodo para borrar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarUnidad(UnidadDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.Unidad.Remove(mapper.Map<UnidadModel>(objModel));
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
        /// Metodo para consultar unidad por id
        /// </summary>
        /// <param name="idUnidad"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUnidadId(int idUnidad)
        {
            Result oRespuesta = new Result();
            UnidadModel? result = new UnidadModel();

            try
            {
                result =
                    await objContext.Unidad.FirstOrDefaultAsync(x => x.Id.Equals(idUnidad));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<UnidadDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<UnidadDto>();
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
