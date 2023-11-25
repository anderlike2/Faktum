
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespTributariaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RetrCodigo { get; set; }
        public string? RetrNombre { get; set; }
        public bool? RetrEstado { get; set; }
        public DateTime? RetrFechaCreacion { get; set; }
        public DateTime? RetrFechaModificacion { get; set; }
    }
}
