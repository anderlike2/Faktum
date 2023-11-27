using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CumModel : BaseEntity
    {
        [Required]
        public int CumsCodigo { get; set; }
        [Required]
        public string? CumsNombre { get; set; }
        [Required]
        public int CumsConsecutivo { get; set; }
        [Required]
        public string? CumsExpediente { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? CumsProductos { get; set; }
    }
}
