
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CondicionVentaModel : BaseEntity
    {
        [Required]
        public string? CoveCodigo { get; set; }
        [Required]
        public string? CoveNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? CoveFacturas{ get; set; }
    }
}
