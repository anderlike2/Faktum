
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
    /// Clase para el manejo de la tabla formatos de impresion
    /// </summary>
    public class FormatoImpresionRepository : IFormatoImpresionRepository
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
        public FormatoImpresionRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los formatos de impresion por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarFormatosImpresionEmpresa(int idEmpresa)
        {
            Result oRespuesta = new Result();
            List<FormatoImpresionModel>? lstResult = new List<FormatoImpresionModel>();

            try
            {
                lstResult =
                    await objContext.FormatoImpresion.Where(x => x.Estado == 1 && x.FormEmpresa.Id.Equals(idEmpresa)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<FormatoImpresionDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<FormatoImpresionDto>();
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
