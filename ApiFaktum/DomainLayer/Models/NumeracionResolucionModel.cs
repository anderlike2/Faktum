using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class NumeracionResolucionModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NureCodigo { get; set; }
        public int NureNumeracionActual { get; set; }
        public bool? NureEstado { get; set; }
        public DateTime? NureFechaCreacion { get; set; }
        public DateTime? NureFechaModificacion { get; set; }
    }
}
