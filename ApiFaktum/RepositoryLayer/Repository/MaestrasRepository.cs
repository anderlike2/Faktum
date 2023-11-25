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
                        var r1 = await objContext.Set<ClaseFacturaModel>().Where(x => x.ClfaEstado != null && (bool)x.ClfaEstado).ToListAsync();
                        foreach (var item in r1)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ClfaCodigo, item.ClfaNombre, item.ClfaEstado, item.ClfaFechaCreacion, item.ClfaFechaModificacion));
                        break;
                    case Constantes.tipoCliente:
                        var r2 = await objContext.Set<TipoClienteModel>().Where(x => x.TiclEstado != null && (bool)x.TiclEstado).ToListAsync();
                        foreach (var item in r2)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiclCodigo, item.TiclNombre, item.TiclEstado, item.TiclFechaCreacion, item.TiclFechaModificacion));
                        break;
                    case Constantes.tipoCups:
                        var r3 = await objContext.Set<TipoCupModel>().Where(x => x.TicuEstado != null && (bool)x.TicuEstado).ToListAsync();
                        foreach (var item in r3)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TicuCodigo, item.TicuNombre, item.TicuEstado, item.TicuFechaCreacion, item.TicuFechaModificacion));
                        break;
                    case Constantes.tipoDocElectr:
                        var r4 = await objContext.Set<TipoDocElectrModel>().Where(x => x.TidoEstado != null && (bool)x.TidoEstado).ToListAsync();
                        foreach (var item in r4)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TidoCodigo, item.TidoNombre, item.TidoEstado, item.TidoFechaCreacion, item.TidoFechaModificacion));
                        break;
                    case Constantes.moneda:
                        var r5 = await objContext.Set<MonedaModel>().Where(x => x.MoneEstado != null && (bool)x.MoneEstado).ToListAsync();
                        foreach (var item in r5)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MoneCodigo, item.MoneNombre, item.MoneEstado, item.MoneFechaCreacion, item.MoneFechaModificacion));
                        break;
                    case Constantes.tipoId:
                        var r6 = await objContext.Set<TipoIdModel>().Where(x => x.TiidEstado != null && (bool)x.TiidEstado).ToListAsync();
                        foreach (var item in r6)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiidCodigo, item.TiidNombre, item.TiidEstado, item.TiidFechaCreacion, item.TiidFechaModificacion));
                        break;
                    case Constantes.tipoDescuento:
                        var r7 = await objContext.Set<TipoDescuentoModel>().Where(x => x.TideEstado != null && (bool)x.TideEstado).ToListAsync();
                        foreach (var item in r7)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TideCodigo, item.TideNombre, item.TideEstado, item.TideFechaCreacion, item.TideFechaModificacion));
                        break;
                    case Constantes.tipoArchivoRips:
                        var r8 = await objContext.Set<TipoArchivoRipsModel>().Where(x => x.ArriEstado != null && (bool)x.ArriEstado).ToListAsync();
                        foreach (var item in r8)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ArriCodigo, item.ArriNombre, item.ArriEstado, item.ArriFechaCreacion, item.ArriFechaModificacion));
                        break;
                    case Constantes.respTributaria:
                        var r9 = await objContext.Set<RespTributariaModel>().Where(x => x.RetrEstado != null && (bool)x.RetrEstado).ToListAsync();
                        foreach (var item in r9)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RetrCodigo, item.RetrNombre, item.RetrEstado, item.RetrFechaCreacion, item.RetrFechaModificacion));
                        break;
                    case Constantes.respFiscal:
                        var r10 = await objContext.Set<RespFiscalModel>().Where(x => x.RefiEstado != null && (bool)x.RefiEstado).ToListAsync();
                        foreach (var item in r10)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RefiCodigo, item.RefiNombre, item.RefiEstado, item.RefiFechaCreacion, item.RefiFechaModificacion));
                        break;
                    case Constantes.formaPago:
                        var r11 = await objContext.Set<FormaPagoModel>().Where(x => x.FopaEstado != null && (bool)x.FopaEstado).ToListAsync();
                        foreach (var item in r11)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FopaCodigo, item.FopaNombre, item.FopaEstado, item.FopaFechaCreacion, item.FopaFechaModificacion));
                        break;
                    case Constantes.factSaludTipo:
                        var r12 = await objContext.Set<FactSaludTipoModel>().Where(x => x.FasaEstado != null && (bool)x.FasaEstado).ToListAsync();
                        foreach (var item in r12)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FasaCodigo, item.FasaNombre, item.FasaEstado, item.FasaFechaCreacion, item.FasaFechaModificacion));
                        break;
                    case Constantes.estadoDianFactura:
                        var r13 = await objContext.Set<EstadoDianFacturaModel>().Where(x => x.EsfaEstado != null && (bool)x.EsfaEstado).ToListAsync();
                        foreach (var item in r13)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.EsfaCodigo, item.EsfaNombre, item.EsfaEstado, item.EsfaFechaCreacion, item.EsfaFechaModificacion));
                        break;
                    case Constantes.cups:
                        var r14 = await objContext.Set<CupModel>().Where(x => x.CupsEstado != null && (bool)x.CupsEstado).ToListAsync();
                        foreach (var item in r14)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CupsCodigo, item.CupsNombre, item.CupsEstado, item.CupsFechaCreacion, item.CupsFechaModificacion));
                        break;
                    case Constantes.condicionVenta:
                        var r15 = await objContext.Set<CondicionVentaModel>().Where(x => x.CoveEstado != null && (bool)x.CoveEstado).ToListAsync();
                        foreach (var item in r15)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CoveCodigo, item.CoveNombre, item.CoveEstado, item.CoveFechaCreacion, item.CoveFechaModificacion));
                        break;
                    case Constantes.pais:
                        var r16 = await objContext.Set<PaisModel>().Where(x => x.PaisEstado != null && (bool)x.PaisEstado).ToListAsync();
                        foreach (var item in r16)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.PaisCodigo, item.PaisNombre, item.PaisEstado, item.PaisFechaCreacion, item.PaisFechaModificacion));
                        break;
                    case Constantes.modalidadPago:
                        var r17 = await objContext.Set<ModalidadPagoModel>().Where(x => x.MopaEstado != null && (bool)x.MopaEstado).ToListAsync();
                        foreach (var item in r17)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MopaCodigo, item.MopaNombre, item.MopaEstado, item.MopaFechaCreacion, item.MopaFechaModificacion));
                        break;
                    case Constantes.conceptoNotas:
                        var r18 = await objContext.Set<ConceptoNotaModel>().Where(x => x.ConoEstado != null && (bool)x.ConoEstado).ToListAsync();
                        foreach (var item in r18)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ConoCodigo, item.ConoNombre, item.ConoEstado, item.ConoFechaCreacion, item.ConoFechaModificacion));
                        break;
                    case Constantes.cobertura:
                        var r19 = await objContext.Set<CoberturaModel>().Where(x => x.CobeEstado != null && (bool)x.CobeEstado).ToListAsync();
                        foreach (var item in r19)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CobeCodigo, item.CobeNombre, item.CobeEstado, item.CobeFechaCreacion, item.CobeFechaModificacion));
                        break;
                    case Constantes.depto:
                        var r20 = await objContext.Set<DeptoModel>().Where(x => x.DeptoEstado != null && (bool)x.DeptoEstado).ToListAsync();
                        foreach (var item in r20)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.DeptoCodigo, item.DeptoNombre, item.DeptoEstado, item.DeptoFechaCreacion, item.DeptoFechaModificacion));
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
        public MaestraDto FormarRespuestaMaestra(int codigo, string? nombre, bool? estado, DateTime? fechaCreacion, DateTime? fechaModificacion)
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
