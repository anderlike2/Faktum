using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoArchivoRipsModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArriCodigo { get; set; }
        public string? ArriNombre { get; set; }
        public bool? ArriEstado { get; set; }
        public DateTime? ArriFechaCreacion { get; set; }
        public DateTime? ArriFechaModificacion { get; set; }
    }
}
