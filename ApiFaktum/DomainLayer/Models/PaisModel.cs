using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class PaisModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaisCodigo { get; set; }
        [Required]
        public string? PaisNombre { get; set; }
        [Required]
        public bool? PaisEstado { get; set; }
        [Required]
        public DateTime? PaisFechaCreacion { get; set; }
        public DateTime? PaisFechaModificacion { get; set; }
    }
}
