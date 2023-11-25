using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class NumeracionResolucionModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NureCodigo { get; set; }
        [Required]
        public int NureNumeracionActual { get; set; }
        [Required]
        public bool? NureEstado { get; set; }
        [Required]
        public DateTime? NureFechaCreacion { get; set; }
        public DateTime? NureFechaModificacion { get; set; }
    }
}
