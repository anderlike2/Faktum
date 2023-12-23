using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class DetalleFactModel : BaseEntity
    {
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaCantidad { get; set; }
        [Required]
        public long DetaCentroCostos { get; set; }
        [Required]
        public string? DetaDescripcion { get; set; }
        [Required]
        public string? DetaFactCodigo { get; set; }
        public DateTime? DetaFechaDespacho { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaIva { get; set; }
        [Required]
        public int DetaLinea { get; set; }
        [Required]
        public string? DetaListaPrecio { get; set; }
        public string? DetaOrdenCompra { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorDescuento { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorcIva { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DetaPorcCrf { get; set; }
        [Required]
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

        //Referencias
        [Required]
        public virtual EmpresaModel? DetaEmpresa { get; set; }
        [Required]
        public virtual FacturaModel? DetaFactura { get; set; }
        [Required]
        public virtual ReteFuenteModel? DetaRetefuente { get; set; }
        [Required]
        public virtual ImpuestoModel? DetaTipoImpuesto { get; set; }
        [Required]
        public virtual UnidadModel? DetaUnidad { get; set; }
        [Required]
        public virtual ListaPrecioModel? DetaListaPrecios { get; set; }

        //Referencias para consultas
        public virtual int DetaEmpresaId { get; set; }
        public virtual int DetaFacturaId { get; set; }
        public virtual int DetaRetefuenteId { get; set; }
        public virtual int DetaTipoImpuestoId { get; set; }
        public virtual int DetaUnidadId { get; set; }
        public virtual int DetaListaPreciosId { get; set; }
    }
}
