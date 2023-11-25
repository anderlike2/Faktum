using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoClienteModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiclCodigo { get; set; }
        public string? TiclNombre { get; set; }
        public bool? TiclEstado { get; set; }
        public DateTime? TiclFechaCreacion { get; set; }
        public DateTime? TiclFechaModificacion { get; set; }
    }
}
