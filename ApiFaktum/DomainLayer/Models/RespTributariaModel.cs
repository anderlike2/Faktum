
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespTributariaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RetrCodigo { get; set; }
        [Required]
        public string? RetrNombre { get; set; }
        [Required]
        public bool? RetrEstado { get; set; }
        [Required]
        public DateTime? RetrFechaCreacion { get; set; }
        public DateTime? RetrFechaModificacion { get; set; }
    }
}
