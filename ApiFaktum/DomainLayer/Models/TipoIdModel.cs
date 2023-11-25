using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoIdModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TiidCodigo { get; set; }
        public string? TiidNombre { get; set; }
        public bool? TiidEstado { get; set; }
        public DateTime? TiidFechaCreacion { get; set; }
        public DateTime? TiidFechaModificacion { get; set; }
    }
}
