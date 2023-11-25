using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoIdModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiidCodigo { get; set; }
        [Required]
        public string? TiidNombre { get; set; }
        [Required]
        public bool? TiidEstado { get; set; }
        [Required]
        public DateTime? TiidFechaCreacion { get; set; }
        public DateTime? TiidFechaModificacion { get; set; }
    }
}
