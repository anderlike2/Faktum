using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class IumModel : BaseEntity
    {
        [Required]
        public string? IumCodigo { get; set; }
        [Required]
        public string? IumNombre { get; set; }
        [Required]
        public string? IumUnidad { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? IumProductos { get; set; }
    }
}
