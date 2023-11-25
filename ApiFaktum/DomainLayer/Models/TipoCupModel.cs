using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoCupModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicuCodigo { get; set; }
        public string? TicuNombre { get; set; }
        public bool? TicuEstado { get; set; }
        public DateTime? TicuFechaCreacion { get; set; }
        public DateTime? TicuFechaModificacion { get; set; }
    }
}
