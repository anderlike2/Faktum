using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClasJuridicaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JuriCodigo { get; set; }
        [Required]
        public string? JuriNombre { get; set; }
        [Required]
        public bool? JuriEstadoOperacion { get; set; }
        [Required]
        public bool? JuriEstado { get; set; }
        [Required]
        public DateTime? JuriFechaCreacion { get; set; }
        public DateTime? JuriFechaModificacion { get; set; }
    }
}
