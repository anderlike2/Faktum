using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RegimenModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegiCodigo { get; set; }
        public string? RegiNombre { get; set; }
        public bool? RegiEstado { get; set; }
        public DateTime? RegiFechaCreacion { get; set; }
        public DateTime? RegiFechaModificacion { get; set; }
    }
}
