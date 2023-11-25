using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Internal;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;
using System.Collections.Generic;
using System.Reflection;
using System.Security.AccessControl;
using System.Text.Json;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de las tablas maestras
    /// </summary>
    public class MaestrasRepository : IMaestrasRepository
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
        public MaestrasRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
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
                        var r1 = await objContext.Set<ClaseFacturaModel>().ToListAsync();
                        foreach (var item in r1)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ClfaCodigo, item.ClfaNombre, item.ClfaEstado, item.ClfaFechaCreacion, item.ClfaFechaModificacion));
                        break;
                    case Constantes.tipoCliente:
                        var r2 = await objContext.Set<TipoClienteModel>().ToListAsync();
                        foreach (var item in r2)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiclCodigo, item.TiclNombre, item.TiclEstado, item.TiclFechaCreacion, item.TiclFechaModificacion));
                        break;
                    case Constantes.tipoCups:
                        var r3 = await objContext.Set<TipoCupModel>().ToListAsync();
                        foreach (var item in r3)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TicuCodigo, item.TicuNombre, item.TicuEstado, item.TicuFechaCreacion, item.TicuFechaModificacion));
                        break;
                    case Constantes.tipoDocElectr:
                        var r4 = await objContext.Set<TipoDocElectrModel>().ToListAsync();
                        foreach (var item in r4)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TidoCodigo, item.TidoNombre, item.TidoEstado, item.TidoFechaCreacion, item.TidoFechaModificacion));
                        break;
                    case Constantes.moneda:
                        var r5 = await objContext.Set<MonedaModel>().ToListAsync();
                        foreach (var item in r5)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MoneCodigo, item.MoneNombre, item.MoneEstado, item.MoneFechaCreacion, item.MoneFechaModificacion));
                        break;
                    case Constantes.tipoId:
                        var r6 = await objContext.Set<TipoIdModel>().ToListAsync();
                        foreach (var item in r6)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TiidCodigo, item.TiidNombre, item.TiidEstado, item.TiidFechaCreacion, item.TiidFechaModificacion));
                        break;
                    case Constantes.tipoDescuento:
                        var r7 = await objContext.Set<TipoDescuentoModel>().ToListAsync();
                        foreach (var item in r7)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.TideCodigo, item.TideNombre, item.TideEstado, item.TideFechaCreacion, item.TideFechaModificacion));
                        break;
                    case Constantes.tipoArchivoRips:
                        var r8 = await objContext.Set<TipoArchivoRipsModel>().ToListAsync();
                        foreach (var item in r8)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ArriCodigo, item.ArriNombre, item.ArriEstado, item.ArriFechaCreacion, item.ArriFechaModificacion));
                        break;
                    case Constantes.respTributaria:
                        var r9 = await objContext.Set<RespTributariaModel>().ToListAsync();
                        foreach (var item in r9)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RetrCodigo, item.RetrNombre, item.RetrEstado, item.RetrFechaCreacion, item.RetrFechaModificacion));
                        break;
                    case Constantes.respFiscal:
                        var r10 = await objContext.Set<RespFiscalModel>().ToListAsync();
                        foreach (var item in r10)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.RefiCodigo, item.RefiNombre, item.RefiEstado, item.RefiFechaCreacion, item.RefiFechaModificacion));
                        break;
                    case Constantes.formaPago:
                        var r11 = await objContext.Set<FormaPagoModel>().ToListAsync();
                        foreach (var item in r11)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FopaCodigo, item.FopaNombre, item.FopaEstado, item.FopaFechaCreacion, item.FopaFechaModificacion));
                        break;
                    case Constantes.factSaludTipo:
                        var r12 = await objContext.Set<FactSaludTipoModel>().ToListAsync();
                        foreach (var item in r12)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.FasaCodigo, item.FasaNombre, item.FasaEstado, item.FasaFechaCreacion, item.FasaFechaModificacion));
                        break;
                    case Constantes.estadoDianFactura:
                        var r13 = await objContext.Set<EstadoDianFacturaModel>().ToListAsync();
                        foreach (var item in r13)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.EsfaCodigo, item.EsfaNombre, item.EsfaEstado, item.EsfaFechaCreacion, item.EsfaFechaModificacion));
                        break;
                    case Constantes.cups:
                        var r14 = await objContext.Set<CupModel>().ToListAsync();
                        foreach (var item in r14)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CupsCodigo, item.CupsNombre, item.CupsEstado, item.CupsFechaCreacion, item.CupsFechaModificacion));
                        break;
                    case Constantes.condicionVenta:
                        var r15 = await objContext.Set<CondicionVentaModel>().ToListAsync();
                        foreach (var item in r15)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CoveCodigo, item.CoveNombre, item.CoveEstado, item.CoveFechaCreacion, item.CoveFechaModificacion));
                        break;
                    case Constantes.pais:
                        var r16 = await objContext.Set<PaisModel>().ToListAsync();
                        foreach (var item in r16)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.PaisCodigo, item.PaisNombre, item.PaisEstado, item.PaisFechaCreacion, item.PaisFechaModificacion));
                        break;
                    case Constantes.modalidadPago:
                        var r17 = await objContext.Set<ModalidadPagoModel>().ToListAsync();
                        foreach (var item in r17)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.MopaCodigo, item.MopaNombre, item.MopaEstado, item.MopaFechaCreacion, item.MopaFechaModificacion));
                        break;
                    case Constantes.conceptoNotas:
                        var r18 = await objContext.Set<ConceptoNotaModel>().ToListAsync();
                        foreach (var item in r18)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.ConoCodigo, item.ConoNombre, item.ConoEstado, item.ConoFechaCreacion, item.ConoFechaModificacion));
                        break;
                    case Constantes.cobertura:
                        var r19 = await objContext.Set<CoberturaModel>().ToListAsync();
                        foreach (var item in r19)
                            lstRespuesta.Add(FormarRespuestaMaestra(item.CobeCodigo, item.CobeNombre, item.CobeEstado, item.CobeFechaCreacion, item.CobeFechaModificacion));
                        break;
                    case Constantes.depto:
                        var r20 = await objContext.Set<DeptoModel>().ToListAsync();
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
