using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FactSaludTipoModel : BaseEntity
    {
        [Required]
        public int FasaCodigo { get; set; }
        [Required]
        public string? FasaNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? FasaFacturas { get; set; }
    }
}
