
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class ListaPrecioProductoModel : BaseEntity
    {
        [Required]
        public virtual ListaPrecioModel? LproListaPrecio { get; set; }
        [Required]
        public virtual ProductoModel? LproProducto { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public virtual decimal? LproValor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public virtual decimal? LproDescuento { get; set; }

        //Referencias para consultas
        public virtual int LproListaPrecioId { get; set; }
        public virtual int LproProductoId { get; set; }
    }
}
