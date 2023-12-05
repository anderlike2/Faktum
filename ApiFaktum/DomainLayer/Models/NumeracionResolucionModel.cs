using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class NumeracionResolucionModel : BaseEntity
    {
        [Required]
        public string? NureCodigo { get; set; }
        [Required]
        public int NureNumeracionActual { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ResolucionModel>? NureResoluciones { get; set; }
    }
}
