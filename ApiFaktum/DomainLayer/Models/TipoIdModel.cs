using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoIdModel : BaseEntity
    {
        [Required]
        public int TiidCodigo { get; set; }
        [Required]
        public string? TiidNombre { get; set; }
    }
}
