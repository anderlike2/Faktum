using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoCupModel : BaseEntity
    {
        [Required]
        public int TicuCodigo { get; set; }
        [Required]
        public string? TicuNombre { get; set; }
    }
}
