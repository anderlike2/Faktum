using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class NumeracionResolucionModel : BaseEntity
    {
        [Required]
        public int NureCodigo { get; set; }
        [Required]
        public int NureNumeracionActual { get; set; }
    }
}
