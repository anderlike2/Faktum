using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class DetalleFactDto : BaseDto
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaCantidad { get; set; }
        public long DetaCentroCostos { get; set; }
        public string? DetaDescripcion { get; set; }
        public string? DetaFactCodigo { get; set; }
        public DateTime? DetaFechaDespacho { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaIva { get; set; }
        public int DetaLinea { get; set; }
        public string? DetaListaPrecio { get; set; }
        public string? DetaOrdenCompra { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorDescuento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorcIva { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorcCrf { get; set; }
        public long DetaProducto { get; set; }
        public string? DetaRemision { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaValorUnitario { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaValReteIca { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaValRf { get; set; }

        //Referencias para consultas
        public int DetaEmpresaId { get; set; }
        public int DetaFacturaId { get; set; }
        public int DetaRetefuenteId { get; set; }
        public int DetaTipoImpuestoId { get; set; }
        public int DetaUnidadId { get; set; }
    }
}
