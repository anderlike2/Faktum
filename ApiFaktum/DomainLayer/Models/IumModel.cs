using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class IumModel : BaseEntity
    {
        [Required]
        public int IumCodigo { get; set; }
        [Required]
        public string? IumNombre { get; set; }
        [Required]
        public string? IumUnidad { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? IumProductos { get; set; }
    }
}
