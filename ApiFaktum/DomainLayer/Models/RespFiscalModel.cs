using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespFiscalModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RefiCodigo { get; set; }
        public string? RefiNombre { get; set; }
        public bool? RefiEstado { get; set; }
        public DateTime? RefiFechaCreacion { get; set; }
        public DateTime? RefiFechaModificacion { get; set; }
    }
}
