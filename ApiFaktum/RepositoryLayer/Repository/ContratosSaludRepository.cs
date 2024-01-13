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
    /// Clase para el manejo de la tabla contratos salud cliente
    /// </summary>
    public class ContratosSaludRepository : IContratosSaludRepository
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
        public ContratosSaludRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los contratos de un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarContratosSaludCliente(int idCliente)
        {
            Result oRespuesta = new Result();
            List<ContratoSaludModel>? lstResult = new List<ContratoSaludModel>();

            try
            {
                lstResult =
                    await objContext.ContratoSalud.Where(x => x.Estado == 1 && x.CosaClie.Id.Equals(idCliente)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<ContratoSaludDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ContratoSaludDto>();
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
        /// Metodo para crear un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearContratoSalud(ContratoSaludDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<ContratoSaludModel>(objModel));
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
        /// Metodo para actualizar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarContratoSalud(ContratoSaludDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<ContratoSaludModel>(objModel));
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
        /// Metodo para borrar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarContratoSalud(ContratoSaludDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.ContratoSalud.Remove(mapper.Map<ContratoSaludModel>(objModel));
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
        /// Metodo para consultar el contrato por id
        /// </summary>
        /// <param name="idContrato"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarContratoId(int idContrato)
        {
            Result oRespuesta = new Result();
            ContratoSaludModel? result = new ContratoSaludModel();

            try
            {
                result =
                    await objContext.ContratoSalud.FirstOrDefaultAsync(x => x.Id.Equals(idContrato));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<ContratoSaludDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ContratoSaludDto>();
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
