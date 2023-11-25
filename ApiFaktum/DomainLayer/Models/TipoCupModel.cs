using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoCupModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicuCodigo { get; set; }
        [Required]
        public string? TicuNombre { get; set; }
        [Required]
        public bool? TicuEstado { get; set; }
        [Required]
        public DateTime? TicuFechaCreacion { get; set; }
        public DateTime? TicuFechaModificacion { get; set; }
    }
}
