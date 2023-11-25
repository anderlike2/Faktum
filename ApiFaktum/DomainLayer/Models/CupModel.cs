using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CupModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CupsCodigo { get; set; }
        [Required]
        public string? CupsNombre { get; set; }
        [Required]
        public bool? CupsEstado { get; set; }
        [Required]
        public DateTime? CupsFechaCreacion { get; set; }
        public DateTime? CupsFechaModificacion { get; set; }
    }
}
