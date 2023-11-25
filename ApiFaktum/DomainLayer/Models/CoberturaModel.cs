using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CoberturaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CobeCodigo { get; set; }
        public string? CobeNombre { get; set; }
        public bool? CobeEstado { get; set; }
        public DateTime? CobeFechaCreacion { get; set; }
        public DateTime? CobeFechaModificacion { get; set; }
    }
}
