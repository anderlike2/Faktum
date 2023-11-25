
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ConceptoNotaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConoCodigo { get; set; }
        public string? ConoNombre { get; set; }
        public bool? ConoEstado { get; set; }
        public DateTime? ConoFechaCreacion { get; set; }
        public DateTime? ConoFechaModificacion { get; set; }
    }
}
