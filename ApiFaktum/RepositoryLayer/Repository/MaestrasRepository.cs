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
    /// Clase para el manejo de las tablas maestras
    /// </summary>
    public class MaestrasRepository : IMaestrasRepository
    {
        private readonly ApplicationDbContext objContext;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <returns></returns>
        public MaestrasRepository(ApplicationDbContext _objContext)
        {
            this.objContext = _objContext;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el usuario        
        /// </summary>
        /// <paramref name="tipoClase"/>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarTablaMaestra(string tipoClase)
        {
            Result oRespuesta = new Result();
            List<MaestraDto> lstRespuesta = new List<MaestraDto>();

            try
            {
                switch (tipoClase)
                {
                    case Constantes.claseFactura:
                        var r1 = await objContext.Set<ClaseFacturaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r1)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ClfaCodigo, item.ClfaNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoCliente:
                        var r2 = await objContext.Set<TipoClienteModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r2)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiclCodigo, item.TiclNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoCups:
                        var r3 = await objContext.Set<TipoCupModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r3)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TicuCodigo, item.TicuNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoDocElectr:
                        var r4 = await objContext.Set<TipoDocElectrModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r4)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TidoCodigo, item.TidoNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.moneda:
                        var r5 = await objContext.Set<MonedaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r5)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MoneCodigo, item.MoneNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoId:
                        var r6 = await objContext.Set<TipoIdModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r6)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiidCodigo, item.TiidNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoDescuento:
                        var r7 = await objContext.Set<TipoDescuentoModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r7)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TideCodigo, item.TideNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.tipoArchivoRips:
                        var r8 = await objContext.Set<TipoArchivoRipsModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r8)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ArriCodigo, item.ArriNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.respTributaria:
                        var r9 = await objContext.Set<RespTributariaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r9)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RetrCodigo, item.RetrNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.respFiscal:
                        var r10 = await objContext.Set<RespFiscalModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r10)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RefiCodigo, item.RefiNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.formaPago:
                        var r11 = await objContext.Set<FormaPagoModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r11)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FopaCodigo, item.FopaNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.factSaludTipo:
                        var r12 = await objContext.Set<FactSaludTipoModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r12)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FasaCodigo, item.FasaNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.estadoDianFactura:
                        var r13 = await objContext.Set<EstadoDianFacturaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r13)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.EsfaCodigo, item.EsfaNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.cups:
                        var r14 = await objContext.Set<CupModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r14)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CupsCodigo, item.CupsNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.condicionVenta:
                        var r15 = await objContext.Set<CondicionVentaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r15)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CoveCodigo, item.CoveNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.pais:
                        var r16 = await objContext.Set<PaisModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r16)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.PaisCodigo, item.PaisNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.modalidadPago:
                        var r17 = await objContext.Set<ModalidadPagoModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r17)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MopaCodigo, item.MopaNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.conceptoNotas:
                        var r18 = await objContext.Set<ConceptoNotaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r18)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ConoCodigo, item.ConoNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                    case Constantes.cobertura:
                        var r19 = await objContext.Set<CoberturaModel>().Where(x => x.Estado == 1).ToListAsync();
                        foreach (var item in r19)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CobeCodigo, item.CobeNombre, item.Estado, item.FechaCreacion, item.FechaModificacion));
                        break;
                }

                oRespuesta.Success = true;
                oRespuesta.Data = lstRespuesta;
            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para armar la respuesta de una tabla maestra   
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaCreacion"></param>
        /// <param name="fechaModificacion"></param>
        /// <returns>Task<Result></returns>
        public MaestraDto FormarRespuestaMaestra(string? codigo, string? nombre, int estado, DateTime? fechaCreacion, DateTime? fechaModificacion)
        {
            return new MaestraDto
            {
                Codigo = codigo,
                Nombre = nombre,
                Estado = estado,
                FechaCreacion = fechaCreacion,
                FechaModificacion = fechaModificacion
            };
        }
    }
}
