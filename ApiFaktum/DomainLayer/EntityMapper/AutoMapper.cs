using AutoMapper;
using DomainLayer.Dtos;
using DomainLayer.Models;

namespace DomainLayer.EntityMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UsuarioModel, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioDto, UsuarioModel>();

            CreateMap<RolModel, RolDto>().ReverseMap();
            CreateMap<RolDto, RolModel>();

            CreateMap<RolUsuarioModel, RolUsuarioDto>().ReverseMap();
            CreateMap<RolUsuarioDto, RolUsuarioModel>();

            CreateMap<CiudadModel, CiudadDto>().ReverseMap();
            CreateMap<CiudadDto, CiudadModel>();

            CreateMap<DeptoModel, DeptoDto>().ReverseMap();
            CreateMap<DeptoDto, DeptoModel>();

            CreateMap<ClasJuridicaModel, ClasJuridicaDto>().ReverseMap();
            CreateMap<ClasJuridicaDto, ClasJuridicaModel>();

            CreateMap<CoberturaModel, CoberturaDto>().ReverseMap();
            CreateMap<CoberturaDto, CoberturaModel>();

            CreateMap<ConceptoNotaModel, ConceptoNotaDto>().ReverseMap();
            CreateMap<ConceptoNotaDto, ConceptoNotaModel>();

            CreateMap<CondicionVentaModel, CondicionVentaDto>().ReverseMap();
            CreateMap<CondicionVentaDto, CondicionVentaModel>();

            CreateMap<CumModel, CumDto>().ReverseMap();
            CreateMap<CumDto, CumModel>();

            CreateMap<CupModel, CupDto>().ReverseMap();
            CreateMap<CupDto, CupModel>();

            CreateMap<EstadoDianFacturaModel, EstadoDianFacturaDto>().ReverseMap();
            CreateMap<EstadoDianFacturaDto, EstadoDianFacturaModel>();

            CreateMap<FactSaludTipoModel, FactSaludTipoDto>().ReverseMap();
            CreateMap<FactSaludTipoDto, FactSaludTipoModel>();

            CreateMap<FormaPagoModel, FormaPagoDto>().ReverseMap();
            CreateMap<FormaPagoDto, FormaPagoModel>();

            CreateMap<ImpuestoModel, ImpuestoDto>().ReverseMap();
            CreateMap<ImpuestoDto, ImpuestoModel>();

            CreateMap<IumModel, IumDto>().ReverseMap();
            CreateMap<IumDto, IumModel>();

            CreateMap<ModalidadPagoModel, ModalidadPagoDto>().ReverseMap();
            CreateMap<ModalidadPagoDto, ModalidadPagoModel>();

            CreateMap<PaisModel, PaisDto>().ReverseMap();
            CreateMap<PaisDto, PaisModel>();

            CreateMap<RegimenModel, RegimenDto>().ReverseMap();
            CreateMap<RegimenDto, RegimenModel>();

            CreateMap<RespFiscalModel, RespFiscalDto>().ReverseMap();
            CreateMap<RespFiscalDto, RespFiscalModel>();

            CreateMap<RespTributariaModel, RespTributariaDto>().ReverseMap();
            CreateMap<RespTributariaDto, RespTributariaModel>();

            CreateMap<ReteFuenteModel, ReteFuenteDto>().ReverseMap();
            CreateMap<ReteFuenteDto, ReteFuenteModel>();

            CreateMap<TipoArchivoRipsModel, TipoArchivoRipsDto>().ReverseMap();
            CreateMap<TipoArchivoRipsDto, TipoArchivoRipsModel>();

            CreateMap<TipoDescuentoModel, TipoDescuentoDto>().ReverseMap();
            CreateMap<TipoDescuentoDto, TipoDescuentoModel>();

            CreateMap<TipoIdModel, TipoIdDto>().ReverseMap();
            CreateMap<TipoIdDto, TipoIdModel>();

            CreateMap<MonedaModel, MonedaDto>().ReverseMap();
            CreateMap<MonedaDto, MonedaModel>();

            CreateMap<TipoDocElectrModel, TipoDocElectrDto>().ReverseMap();
            CreateMap<TipoDocElectrDto, TipoDocElectrModel>();

            CreateMap<TipoCupModel, TipoCupDto>().ReverseMap();
            CreateMap<TipoCupDto, TipoCupModel>();

            CreateMap<TipoClienteModel, TipoClienteDto>().ReverseMap();
            CreateMap<TipoClienteDto, TipoClienteModel>();

            CreateMap<ClaseFacturaModel, ClaseFacturaDto>().ReverseMap();
            CreateMap<ClaseFacturaDto, ClaseFacturaModel>();

            CreateMap<LocalidadModel, LocalidadDto>().ReverseMap();
            CreateMap<LocalidadDto, LocalidadModel>();

            CreateMap<EmpresaModel, EmpresaDto>().ReverseMap();
            CreateMap<EmpresaDto, EmpresaModel>();

            CreateMap<FormatoImpresionModel, FormatoImpresionDto>().ReverseMap();
            CreateMap<FormatoImpresionDto, FormatoImpresionModel>();

            CreateMap<UnidadModel, UnidadDto>().ReverseMap();
            CreateMap<UnidadDto, UnidadModel>();

            CreateMap<CentroCostoModel, CentroCostoDto>().ReverseMap();
            CreateMap<CentroCostoDto, CentroCostoModel>();

            CreateMap<ProductoModel, ProductoDto>().ReverseMap();
            CreateMap<ProductoDto, ProductoModel>();

            CreateMap<FacturaModel, FacturaDto>().ReverseMap();
            CreateMap<FacturaDto, FacturaModel>();

            CreateMap<DetalleFactModel, DetalleFactDto>().ReverseMap();
            CreateMap<DetalleFactDto, DetalleFactModel>();

            CreateMap<VendedorModel, VendedorDto>().ReverseMap();
            CreateMap<VendedorDto, VendedorModel>();

            CreateMap<ListaPrecioModel, ListaPrecioDto>().ReverseMap();
            CreateMap<ListaPrecioDto, ListaPrecioModel>();

            CreateMap<NotaDebitoModel, NotaDebitoDto>().ReverseMap();
            CreateMap<NotaDebitoDto, NotaDebitoModel>();

            CreateMap<NotaCreditoModel, NotaCreditoDto>().ReverseMap();
            CreateMap<NotaCreditoDto, NotaCreditoModel>();

            CreateMap<SucursalModel, SucursalDto>().ReverseMap();
            CreateMap<SucursalDto, SucursalModel>();

            CreateMap<ClienteModel, ClienteDto>().ReverseMap();
            CreateMap<ClienteDto, ClienteModel>();

            CreateMap<ResolucionModel, ResolucionDto>().ReverseMap();
            CreateMap<ResolucionDto, ResolucionModel>();

            CreateMap<ContratoSaludModel, ContratoSaludDto>().ReverseMap();
            CreateMap<ContratoSaludDto, ContratoSaludModel>();

            CreateMap<EmpresasUsuarioModel, EmpresasUsuarioDto>().ReverseMap();
            CreateMap<EmpresasUsuarioDto, EmpresasUsuarioModel>();

            CreateMap<OtroProductoModel, OtroProductoDto>().ReverseMap();
            CreateMap<OtroProductoDto, OtroProductoModel>();

            CreateMap<ResolucionSucursalModel, ResolucionSucursalDto>().ReverseMap();
            CreateMap<ResolucionSucursalDto, ResolucionSucursalModel>();

            CreateMap<UsuarioSaludRips, UsuarioSaludRipsDto>().ReverseMap();
            CreateMap<UsuarioSaludRipsDto, UsuarioSaludRips>();

            CreateMap<ConsultaRips, ConsultaRipsDto>().ReverseMap();
            CreateMap<ConsultaRipsDto, ConsultaRips>();
        }
    }
}
