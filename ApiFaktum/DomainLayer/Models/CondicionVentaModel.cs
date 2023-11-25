
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CondicionVentaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoveCodigo { get; set; }
        [Required]
        public string? CoveNombre { get; set; }
        [Required]
        public bool? CoveEstado { get; set; }
        [Required]
        public DateTime? CoveFechaCreacion { get; set; }
        public DateTime? CoveFechaModificacion { get; set; }
    }
}
