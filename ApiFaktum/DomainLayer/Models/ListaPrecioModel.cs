using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class ListaPrecioModel : BaseEntity
    {
        [Required]
        public string? LiprDescripcion { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiprDescuento { get; set; }
        [Required]
        public int LiprEstadoOperacion { get; set; }
        [Required]
        public string? LiprNombre { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiprValor { get; set; }

        //Referencias
        [Required]
        public virtual ProductoModel? LiprProducto { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? LiprFacturas { get; set; }
        [Required]
        public virtual ICollection<DetalleFactModel>? LiprDetFacturas { get; set; }        

        //Referencias para consultas
        public virtual int LiprProductoId { get; set; }
    }
}
