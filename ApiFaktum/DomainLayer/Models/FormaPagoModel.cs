using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FormaPagoModel : BaseEntity
    {
        [Required]
        public int FopaCodigo { get; set; }
        [Required]
        public string? FopaNombre { get; set; }
    }
}
