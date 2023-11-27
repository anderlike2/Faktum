using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ConceptoNotaModel : BaseEntity
    {
        [Required]
        public int ConoCodigo { get; set; }
        [Required]
        public string? ConoNombre { get; set; }
    }
}
