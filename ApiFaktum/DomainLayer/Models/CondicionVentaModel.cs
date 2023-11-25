
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CondicionVentaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoveCodigo { get; set; }
        public string? CoveNombre { get; set; }
        public bool? CoveEstado { get; set; }
        public DateTime? CoveFechaCreacion { get; set; }
        public DateTime? CoveFechaModificacion { get; set; }
    }
}
