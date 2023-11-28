using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FormaPagoModel : BaseEntity
    {
        [Required]
        public string? FopaCodigo { get; set; }
        [Required]
        public string? FopaNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? FopaFacturas { get; set; }
    }
}
