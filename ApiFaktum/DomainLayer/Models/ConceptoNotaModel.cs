
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ConceptoNotaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConoCodigo { get; set; }
        [Required]
        public string? ConoNombre { get; set; }
        [Required]
        public bool? ConoEstado { get; set; }
        [Required]
        public DateTime? ConoFechaCreacion { get; set; }
        public DateTime? ConoFechaModificacion { get; set; }
    }
}
