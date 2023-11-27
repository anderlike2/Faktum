using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClaseFacturaModel : BaseEntity
    {
        [Required]
        public int ClfaCodigo { get; set; }
        [Required]
        public string? ClfaNombre { get; set; }
    }
}
