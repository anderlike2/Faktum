using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FormaPagoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FopaCodigo { get; set; }
        [Required]
        public string? FopaNombre { get; set; }
        [Required]
        public bool? FopaEstado { get; set; }
        [Required]
        public DateTime? FopaFechaCreacion { get; set; }
        public DateTime? FopaFechaModificacion { get; set; }
    }
}
