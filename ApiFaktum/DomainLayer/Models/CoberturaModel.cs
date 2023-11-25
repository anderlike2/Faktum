using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CoberturaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CobeCodigo { get; set; }
        [Required]
        public string? CobeNombre { get; set; }
        [Required]
        public bool? CobeEstado { get; set; }
        [Required]
        public DateTime? CobeFechaCreacion { get; set; }
        public DateTime? CobeFechaModificacion { get; set; }
    }
}
