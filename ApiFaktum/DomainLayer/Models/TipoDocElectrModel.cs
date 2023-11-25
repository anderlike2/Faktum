using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoDocElectrModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TidoCodigo { get; set; }
        public string? TidoNombre { get; set; }
        public bool? TidoEstado { get; set; }
        public DateTime? TidoFechaCreacion { get; set; }
        public DateTime? TidoFechaModificacion { get; set; }
    }
}
