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
    /// Clase para el manejo de la tabla resoluciones con sucursal
    /// </summary>
    public class ResolucionSucursalRepository : IResolucionSucursalRepository
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
        public ResolucionSucursalRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearResolucionSucursal(ResolucionSucursalDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<ResolucionSucursalModel>(objModel));
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
        /// Metodo para actualizar informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarResolucionSucursal(ResolucionSucursalDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<ResolucionSucursalModel>(objModel));
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
        /// Metodo para validar informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ValidarResolucionSucursal(ResolucionSucursalDto objModel)
        {
            Result oRespuesta = new Result();

            ResolucionSucursalModel? result = new ResolucionSucursalModel();
            ResolucionSucursalDto temp = new ResolucionSucursalDto();

            try
            {
                result = await objContext.ResolucionSucursal.AsNoTracking().Where(x => x.ResuResolucionId.Equals(objModel.ResuResolucionId) && x.ResuSucursalId.Equals(objModel.ResuSucursalId)).FirstOrDefaultAsync();

                if (result != null)
                {
                    temp = mapper.Map<ResolucionSucursalDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
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
        /// Metodo para consultar la resolucion sucursal por id
        /// </summary>
        /// <param name="idResolucionSucursal"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarResolucionSucursalId(int idResolucionSucursal)
        {
            Result oRespuesta = new Result();
            ResolucionSucursalModel? result = new ResolucionSucursalModel();

            try
            {
                result =
                    await objContext.ResolucionSucursal.FirstOrDefaultAsync(x => x.Id.Equals(idResolucionSucursal));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<ResolucionSucursalDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ResolucionSucursalDto>();
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
