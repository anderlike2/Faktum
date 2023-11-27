using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolModel : BaseEntity
    {
        [Required]
        public int RolCodigo { get; set; }
        [Required]
        public string? RolDescripcion { get; set; }    
    }
}
