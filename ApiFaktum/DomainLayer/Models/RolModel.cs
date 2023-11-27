using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolModel : BaseEntity
    {
        [Required]
        public string? RolCodigo { get; set; }
        [Required]
        public string? RolDescripcion { get; set; }    
    }
}
