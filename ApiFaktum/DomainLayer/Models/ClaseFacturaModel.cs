using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClaseFacturaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClfaCodigo { get; set; }
        public string? ClfaNombre { get; set; }
        public bool? ClfaEstado { get; set; }
        public DateTime? ClfaFechaCreacion { get; set; }
        public DateTime? ClfaFechaModificacion { get; set; }
    }
}
