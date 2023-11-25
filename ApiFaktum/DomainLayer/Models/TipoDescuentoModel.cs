using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDescuentoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TideCodigo { get; set; }
        [Required]
        public string? TideNombre { get; set; }
        [Required]
        public bool? TideEstado { get; set; }
        [Required]
        public DateTime? TideFechaCreacion { get; set; }
        public DateTime? TideFechaModificacion { get; set; }
    }
}
