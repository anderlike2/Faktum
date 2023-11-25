using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class EstadoDianFacturaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EsfaCodigo { get; set; }
        [Required]
        public string? EsfaNombre { get; set; }
        [Required]
        public bool? EsfaEstado { get; set; }
        [Required]
        public DateTime? EsfaFechaCreacion { get; set; }
        public DateTime? EsfaFechaModificacion { get; set; }
    }
}
