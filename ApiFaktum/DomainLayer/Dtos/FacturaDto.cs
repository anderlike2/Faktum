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
        public decimal? FactCopago { get; set; }
        public string? FactCufe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactCuotaRecupera { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactDescGlobal { get; set; }
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
        public decimal? FactPoliza { get; set; }
        public decimal? FactPorcIva { get; set; }
        public string? FactRecepcion { get; set; }
        public string? FactRemision { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactSubtotal { get; set; }
        public string? FactSucursal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactTotalIva { get; set; }
        public decimal? FactTotalReteIca { get; set; }
        public string? FactTrm { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactValAnticipo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactValorDescuento { get; set; }
        public decimal? FactValTotRetefuente { get; set; }
        public string? FactVendedor { get; set; }

        //Referencias para consultas
        public int FactClaseFacturaId { get; set; }
        public int FactCoberturaId { get; set; }
        public int FactCondicionVentaId { get; set; }
        public int FactEmpresaId { get; set; }
        public int FactEstadoDianId { get; set; }
        public int FactFormaPagoId { get; set; }
        public int FactFormatoImpresionId { get; set; }
        public int FactMonedaId { get; set; }
        public int FactSaludTipoId { get; set; }
        public int FactTipoDescuentoId { get; set; }
        public int FactTipoDocElectrId { get; set; }
        public int? FactNotaDebitoId { get; set; }
        public int? FactNotaCreditoId { get; set; }
        public int FactClienteId { get; set; }
    }
}
