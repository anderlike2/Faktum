using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CupModel : BaseEntity
    {
        [Required]
        public string? CupsCodigo { get; set; }
        [Required]
        public string? CupsNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? CupsProductos { get; set; }
    }
}
