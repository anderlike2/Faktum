using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoArchivoRipsModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArriCodigo { get; set; }
        [Required]
        public string? ArriNombre { get; set; }
        [Required]
        public bool? ArriEstado { get; set; }
        [Required]
        public DateTime? ArriFechaCreacion { get; set; }
        public DateTime? ArriFechaModificacion { get; set; }
    }
}
