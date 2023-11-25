using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDescuentoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TideCodigo { get; set; }
        public string? TideNombre { get; set; }
        public bool? TideEstado { get; set; }
        public DateTime? TideFechaCreacion { get; set; }
        public DateTime? TideFechaModificacion { get; set; }
    }
}
