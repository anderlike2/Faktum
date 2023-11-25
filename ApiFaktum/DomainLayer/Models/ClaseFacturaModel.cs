using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClaseFacturaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClfaCodigo { get; set; }
        [Required]
        public string? ClfaNombre { get; set; }
        [Required]
        public bool? ClfaEstado { get; set; }
        [Required]
        public DateTime? ClfaFechaCreacion { get; set; }
        public DateTime? ClfaFechaModificacion { get; set; }
    }
}
