using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class FacturaDto : BaseDto
    {
        public DateTime? FactFechaTrm { get; set; }
        public long FactCompartidos { get; set; }
        public long FactContador { get; set; }
        public string? FactContrato { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactCopago { get; set; }
        public string? FactCufe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactCuotaRecupera { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactDescGlobal { get; set; }
        public string? FactDespacho { get; set; }
        public int FactEstadoOperacion { get; set; }
        public DateTime? FactFecha { get; set; }
        public DateTime? FactFechaFinal { get; set; }
        public DateTime? FactFechaInicio { get; set; }
        public DateTime? FactFechaVence { get; set; }
        public string? FactModalidadPago { get; set; }
        public long FactModeradora { get; set; }
        public string? FactNumero { get; set; }
        public string? FactObservaciones { get; set; }
        public string? FactOperador { get; set; }
        public string? FactOrden { get; set; }
        public string? FactPoliza { get; set; }
        public string? FactPorcIva { get; set; }
        public string? FactRecepcion { get; set; }
        public string? FactRemision { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactSubtotal { get; set; }
        public string? FactSucursal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactTotalIva { get; set; }
        public string? FactTotalReteIca { get; set; }
        public string? FactTrm { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValAnticipo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValorDescuento { get; set; }
        public string? FactValTotRetefuente { get; set; }
        public string? FactVendedor { get; set; }

        //Referencias
        public ClaseFacturaDto? FactClaseFactura { get; set; }
        public CoberturaDto? FactCobertura { get; set; }
        public CondicionVentaDto? FactCondicionVenta { get; set; }
        public EmpresaDto? FactEmpresa { get; set; }
        public EstadoDianFacturaDto? FactEstadoDian { get; set; }
        public FormaPagoDto? FactFormaPago { get; set; }
        public FormatoImpresionDto? FactFormatoImpresion { get; set; }
        public MonedaDto? FactMoneda { get; set; }
        public FactSaludTipoDto? FactSaludTipo { get; set; }
        public TipoDescuentoDto? FactTipoDescuento { get; set; }
        public TipoDocElectrDto? FactTipoDocElectr { get; set; }
        public List<DetalleFactDto>? FactDetFacturas { get; set; }
        public ListaPrecioDto? FactListaPrecios { get; set; }
        public NotaDebitoDto? FactNotaDebito { get; set; }
        public NotaCreditoDto? FactNotaCredito { get; set; }
        public ClienteDto? FactCliente { get; set; }
    }
}
