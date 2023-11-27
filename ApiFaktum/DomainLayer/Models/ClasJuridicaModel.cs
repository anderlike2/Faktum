using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClasJuridicaModel : BaseEntity
    {
        [Required]
        public int JuriCodigo { get; set; }
        [Required]
        public string? JuriNombre { get; set; }
        [Required]
        public int JuriEstadoOperacion { get; set; }
    }
}
