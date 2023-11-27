using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDocElectrModel : BaseEntity
    {
        [Required]
        public int TidoCodigo { get; set; }
        [Required]
        public string? TidoNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? TidoFacturas { get; set; }
    }
}
