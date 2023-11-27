
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CondicionVentaModel : BaseEntity
    {
        [Required]
        public int CoveCodigo { get; set; }
        [Required]
        public string? CoveNombre { get; set; }
    }
}
