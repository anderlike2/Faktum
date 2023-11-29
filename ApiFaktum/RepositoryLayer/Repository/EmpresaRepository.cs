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

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las empresas por usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarEmpresasUsuario(int idUsuario)
        {
            Result oRespuesta = new Result();
            List<EmpresaModel>? lstResult = new List<EmpresaModel>();

            try
            {
                lstResult = await (from empusu in objContext.EmpresasUsuario
                                   join emp in objContext.Empresa on empusu.EmusEmpresa.Id equals emp.Id
                                   where empusu.EmusUsuario.Id == idUsuario
                                   select new EmpresaModel
                                   {
                                       EmprFactContador = emp.EmprFactContador,
                                       EmprCelular = emp.EmprCelular,
                                       EmprCiudad = emp.EmprCiudad,
                                       EmprCiuu = emp.EmprCiuu,
                                       EmprContacto = emp.EmprContacto,
                                       EmprDepto = emp.EmprDepto,
                                       EmprDiasPago = emp.EmprDiasPago,
                                       EmprDireccion = emp.EmprDireccion,
                                       EmprDv = emp.EmprDv,
                                       EmprFormatoImpr = emp.EmprFormatoImpr,
                                       EmprIdRepLegal = emp.EmprIdRepLegal,
                                       EmprLeyEnFactura = emp.EmprLeyEnFactura,
                                       EmprLeyEnNotaCredito = emp.EmprLeyEnNotaCredito,
                                       EmprLeyEnNotaDebito = emp.EmprLeyEnNotaDebito,
                                       EmprLocalidad = emp.EmprLocalidad,
                                       EmprMail = emp.EmprMail,
                                       EmprRecepcion = emp.EmprRecepcion,
                                       EmprNit = emp.EmprNit,
                                       EmprNombre = emp.EmprNombre,
                                       EmprObservaciones = emp.EmprObservaciones,
                                       EmprPagWeb = emp.EmprPagWeb,
                                       EmprPorcReteIca = emp.EmprPorcReteIca,
                                       EmprRepLegal = emp.EmprRepLegal,
                                       EmprTelefono = emp.EmprTelefono,
                                       EmprHabilitacion = emp.EmprHabilitacion,
                                       EmprTipoCliente = emp.EmprTipoCliente,
                                       EmprTipoId = emp.EmprTipoId,
                                       EmprRespTribut = emp.EmprRespTribut,
                                       EmprRegimen = emp.EmprRegimen,
                                       EmprRespFiscal = emp.EmprRespFiscal,
                                       EmprClasJuridica = emp.EmprClasJuridica,
                                       Estado = emp.Estado,
                                       FechaCreacion = emp.FechaCreacion,
                                       FechaModificacion = emp.FechaModificacion
                                   }).ToListAsync();

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

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una empresa
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearEmpresa(EmpresaDto objModel)
        {
            return null;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una empresa
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarEmpresa(EmpresaDto objModel)
        {
            return null;
        }
    }
}
