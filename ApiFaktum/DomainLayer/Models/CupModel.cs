using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CupModel : BaseEntity
    {
        [Required]
        public int CupsCodigo { get; set; }
        [Required]
        public string? CupsNombre { get; set; }
    }
}
