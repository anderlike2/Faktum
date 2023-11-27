using AutoMapper;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla Regimen
    /// </summary>
    public class RegimenRepository : IRegimenRepository
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
        public RegimenRepository(ApplicationDbContext _objContext, IMapper _mapper)
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
            List<RegimenModel>? lstResult = new List<RegimenModel>();

            try
            {
                lstResult = await objContext.Regimen.Include(x => x.Estado == 1).ToListAsync();

                if (lstResult.Count > 0)
                {
                    oRespuesta.Success = true;
                    oRespuesta.Data = mapper.Map<List<RegimenDto>>(lstResult);
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }
    }
}
