using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CupModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CupsCodigo { get; set; }
        public string? CupsNombre { get; set; }
        public bool? CupsEstado { get; set; }
        public DateTime? CupsFechaCreacion { get; set; }
        public DateTime? CupsFechaModificacion { get; set; }
    }
}
