using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ReteFuenteModel : BaseEntity
    {
        [Required]
        public int ReteCodigo { get; set; }
        [Required]
        public string? ReteNombre { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? RetePorcentaje { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? ReteProductos { get; set; }
    }
}
