using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class EstadoDianFacturaModel : BaseEntity
    {
        [Required]
        public int EsfaCodigo { get; set; }
        [Required]
        public string? EsfaNombre { get; set; }
    }
}
