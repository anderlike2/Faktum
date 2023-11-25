using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespFiscalModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RefiCodigo { get; set; }
        [Required]
        public string? RefiNombre { get; set; }
        [Required]
        public bool? RefiEstado { get; set; }
        [Required]
        public DateTime? RefiFechaCreacion { get; set; }
        public DateTime? RefiFechaModificacion { get; set; }
    }
}
