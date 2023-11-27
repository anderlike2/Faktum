using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class PaisModel : BaseEntity
    {
        [Required]
        public int PaisCodigo { get; set; }
        [Required]
        public string? PaisNombre { get; set; }
    }
}
