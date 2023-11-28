using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDocElectrModel : BaseEntity
    {
        [Required]
        public string? TidoCodigo { get; set; }
        [Required]
        public string? TidoNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? TidoFacturas { get; set; }
        [Required]
        public virtual ICollection<ResolucionModel>? TidoResoluciones { get; set; }
    }
}
