using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDescuentoModel : BaseEntity
    {
        [Required]
        public string? TideCodigo { get; set; }
        [Required]
        public string? TideNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? TideFacturas { get; set; }
    }
}
