using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class EstadoDianFacturaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EsfaCodigo { get; set; }
        public string? EsfaNombre { get; set; }
        public bool? EsfaEstado { get; set; }
        public DateTime? EsfaFechaCreacion { get; set; }
        public DateTime? EsfaFechaModificacion { get; set; }
    }
}
