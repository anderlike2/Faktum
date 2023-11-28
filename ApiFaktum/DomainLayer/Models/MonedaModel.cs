using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class MonedaModel : BaseEntity
    {
        [Required]
        public string? MoneCodigo { get; set; }
        [Required]
        public string? MoneNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? MoneFacturas { get; set; }
    }
}
