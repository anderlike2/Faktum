using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class FacturaModel : BaseEntity
    {
        [Required]
        public DateTime? FactFechaTrm { get; set;}
        public long? FactCompartidos { get; set;}
        [Required]
        public long FactContador { get; set; }
        public string? FactContrato { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactCopago { get; set; }
        [Required]
        public string? FactCufe { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? FactCuotaRecupera { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactDescGlobal{ get; set; }
        [Required]
        public string? FactDespacho { get; set; }
        [Required]
        public int FactEstadoOperacion { get; set; }
        [Required]
        public DateTime? FactFecha { get; set; }
        public DateTime? FactFechaFinal { get; set; }
        public DateTime? FactFechaInicio { get; set; }
        [Required]
        public DateTime? FactFechaVence { get; set; }
        [Required]
        public string? FactModalidadPago { get; set; }
        public long? FactModeradora { get; set; }
        [Required]
        public string? FactNumero { get; set; }
        [Required]
        public string? FactObservaciones { get; set; }
        [Required]
        public string? FactOperador { get; set; }
        [Required]
        public string? FactOrden { get; set; }
        public string? FactPoliza { get; set; }
        [Required]
        public string? FactPorcIva { get; set; }
        [Required]
        public string? FactRecepcion { get; set; }
        [Required]
        public string? FactRemision { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactSubtotal { get; set; }
        [Required]
        public string? FactSucursal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactTotalIva { get; set; }
        [Required]
        public string? FactTotalReteIca { get; set; }
        [Required]
        public string? FactTrm { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValAnticipo { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal FactValorDescuento { get; set; }
        [Required]
        public string? FactValTotRetefuente { get; set; }
        [Required]
        public string? FactVendedor{ get; set; }

        //Referencias
        [Required]
        public virtual ClaseFacturaModel? FactClaseFactura { get; set; }
        [Required]
        public virtual CoberturaModel? FactCobertura { get; set; }
        [Required]
        public virtual CondicionVentaModel? FactCondicionVenta { get; set; }
        [Required]
        public virtual EmpresaModel? FactEmpresa { get; set; }
        [Required]
        public virtual EstadoDianFacturaModel? FactEstadoDian { get; set; }
        [Required]
        public virtual FormaPagoModel? FactFormaPago { get; set; }
        [Required]
        public virtual FormatoImpresionModel? FactFormatoImpresion { get; set; }
        [Required]
        public virtual MonedaModel? FactMoneda { get; set; }
        [Required]
        public virtual FactSaludTipoModel? FactSaludTipo { get; set; }
        [Required]
        public virtual TipoDescuentoModel? FactTipoDescuento { get; set; }
        [Required]
        public virtual TipoDocElectrModel? FactTipoDocElectr { get; set; }
        [Required]
        public virtual ICollection<DetalleFactModel>? FactDetFacturas { get; set; }
        [Required]
        public virtual ListaPrecioModel? FactListaPrecios { get; set; }
        [Required]
        public virtual NotaDebitoModel? FactNotaDebito { get; set; }
        [Required]
        public virtual NotaCreditoModel? FactNotaCredito { get; set; }
        [Required]
        public virtual ClienteModel? FactCliente { get; set; }

        //Referencias para consultas
        public virtual int FactClaseFacturaId { get; set; }
        public virtual int FactCoberturaId { get; set; }
        public virtual int FactCondicionVentaId { get; set; }
        public virtual int FactEmpresaId { get; set; }
        public virtual int FactEstadoDianId { get; set; }
        public virtual int FactFormaPagoId { get; set; }
        public virtual int FactFormatoImpresionId { get; set; }
        public virtual int FactMonedaId { get; set; }
        public virtual int FactSaludTipoId { get; set; }
        public virtual int FactTipoDescuentoId { get; set; }
        public virtual int FactTipoDocElectrId { get; set; }
        public virtual int FactListaPreciosId { get; set; }
        public virtual int FactNotaDebitoId { get; set; }
        public virtual int FactNotaCreditoId { get; set; }
        public virtual int FactClienteId { get; set; }

    }
}
