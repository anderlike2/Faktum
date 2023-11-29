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
    /// Clase para el manejo de la tabla empresa
    /// </summary>
    public class EmpresaRepository : IEmpresaRepository
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
        public EmpresaRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las empresas
        /// </summary>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarEmpresas()
        {
            Result oRespuesta = new Result();
            List<EmpresaModel>? lstResult = new List<EmpresaModel>();

            try
            {
                lstResult = 
                    await objContext.Empresa.Where(x => x.Estado == 1).Include(z => z.EmprTipoCliente).Include(z => z.EmprTipoId)
                    .Include(z => z.EmprRespTribut).Include(z => z.EmprRegimen).Include(z => z.EmprRespFiscal).Include(z => z.EmprClasJuridica).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<EmpresaDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<EmpresaDto>();
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
