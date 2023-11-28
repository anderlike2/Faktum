using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class EmpresaDto : BaseDto
    {
        public int EmprFactContador { get; set; }
        public string? EmprCelular { get; set; }
        public string? EmprCiudad { get; set; }
        public string? EmprCiuu { get; set; }        
        public string? EmprContacto { get; set; }
        public string? EmprDepto { get; set; }
        public int EmprDiasPago { get; set; }
        public string? EmprDireccion { get; set; }
        public string? EmprDv { get; set; }       
        public string? EmprFormatoImpr { get; set; }
        public string? EmprIdRepLegal { get; set; }
        public string? EmprLeyEnFactura { get; set; }
        public string? EmprLeyEnNotaCredito { get; set; }
        public string? EmprLeyEnNotaDebito { get; set; }
        public string? EmprLocalidad { get; set; }
        public string? EmprMail { get; set; }
        public string? EmprRecepcion { get; set; }
        public string? EmprNit { get; set; }
        public string? EmprNombre { get; set; }
        public string? EmprObservaciones { get; set; }
        public string? EmprPagWeb { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EmprPorcReteIca { get; set; }       
        public string? EmprRepLegal { get; set; }        
        public string? EmprTelefono { get; set; }        
        public string? EmprHabilitacion { get; set; }

        //Referencias
        public TipoClienteDto? EmprTipoCliente { get; set; }
        public TipoIdDto? EmprTipoId { get; set; }
        public RespTributariaDto? EmprRespTribut { get; set; }
        public RegimenDto? EmprRegimen { get; set; }
        public RespFiscalDto? EmprRespFiscal { get; set; }
        public ClasJuridicaDto? EmprClasJuridica { get; set; }
        public List<ProductoDto>? EmprProductos { get; set; }
        public List<CentroCostoDto>? EmprCentroCostos { get; set; }
        public List<FormatoImpresionDto>? EmprFormatosImpresion { get; set; }
        public List<FacturaDto>? EmprFacturas { get; set; }
        public List<DetalleFactDto>? EmprDetFacturas { get; set; }
        public List<VendedorDto>? EmprVendedores { get; set; }
        public List<ListaPrecioDto>? EmprListaPrecios { get; set; }
        public List<NotaDebitoDto>? EmprNotasDebito { get; set; }
        public List<NotaCreditoDto>? EmprNotasCredito { get; set; }
        public List<SucursalDto>? EmprSucursales { get; set; }
        public List<SucursalClienteDto>? EmprSucursalesCliente { get; set; }
        public List<ClienteDto>? EmprClientes { get; set; }
        public List<ResolucionDto>? EmprResoluciones { get; set; }
        public List<ContratoSaludDto>? EmprContratosSalud { get; set; }

    }
}
