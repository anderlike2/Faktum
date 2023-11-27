using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespFiscalModel : BaseEntity
    {
        [Required]
        public int RefiCodigo { get; set; }
        [Required]
        public string? RefiNombre { get; set; }
    }
}
