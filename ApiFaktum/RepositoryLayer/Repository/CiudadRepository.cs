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
    /// Clase para el manejo de la tabla Ciudad
    /// </summary>
    public class CiudadRepository : ICiudadRepository
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
        public CiudadRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla
        /// </summary>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarTabla()
        {
            Result oRespuesta = new Result();
            List<CiudadModel>? lstResult = new List<CiudadModel>();

            try
            {                
                lstResult = await objContext.Ciudad.Where(x => x.Estado == 1).Include(z => z.CiudDepto).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<CiudadDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<CiudadDto>();
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
        /// Metodo para consultar la ciudades de un departamento
        /// </summary>
        /// <param name="idDepto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarCiudadesDepto(int idDepto)
        {
            Result oRespuesta = new Result();
            List<CiudadModel>? lstResult = new List<CiudadModel>();

            try
            {
                lstResult = await objContext.Ciudad.Where(x => x.Estado == 1 && x.CiudDepto.Id.Equals(idDepto)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<CiudadDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<CiudadDto>();
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
