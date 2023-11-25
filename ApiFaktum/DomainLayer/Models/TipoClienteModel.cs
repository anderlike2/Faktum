using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoClienteModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiclCodigo { get; set; }
        [Required]
        public string? TiclNombre { get; set; }
        [Required]
        public bool? TiclEstado { get; set; }
        [Required]
        public DateTime? TiclFechaCreacion { get; set; }
        public DateTime? TiclFechaModificacion { get; set; }
    }
}
