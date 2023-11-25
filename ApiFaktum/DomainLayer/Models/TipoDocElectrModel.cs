using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDocElectrModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TidoCodigo { get; set; }
        [Required]
        public string? TidoNombre { get; set; }
        [Required]
        public bool? TidoEstado { get; set; }
        [Required]
        public DateTime? TidoFechaCreacion { get; set; }
        public DateTime? TidoFechaModificacion { get; set; }
    }
}
