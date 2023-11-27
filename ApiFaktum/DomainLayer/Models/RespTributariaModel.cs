
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespTributariaModel : BaseEntity
    {
        [Required]
        public int RetrCodigo { get; set; }
        [Required]
        public string? RetrNombre { get; set; }
    }
}
