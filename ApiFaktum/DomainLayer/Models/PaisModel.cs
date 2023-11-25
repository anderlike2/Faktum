using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class PaisModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaisCodigo { get; set; }
        public string? PaisNombre { get; set; }
        public bool? PaisEstado { get; set; }
        public DateTime? PaisFechaCreacion { get; set; }
        public DateTime? PaisFechaModificacion { get; set; }
    }
}
