using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RegimenModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegiCodigo { get; set; }
        [Required]
        public string? RegiNombre { get; set; }
        [Required]
        public bool? RegiEstadoOperacion { get; set; }
        [Required]
        public bool? RegiEstado { get; set; }
        [Required]
        public DateTime? RegiFechaCreacion { get; set; }
        public DateTime? RegiFechaModificacion { get; set; }
    }
}
