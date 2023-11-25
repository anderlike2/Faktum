using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CumModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CumsCodigo { get; set; }
        public string? CumsNombre { get; set; }
        public int CumsConsecutivo { get; set; }
        public string? CumsExpediente { get; set; }
        public bool? CumsEstado { get; set; }
        public DateTime? CumsFechaCreacion { get; set; }
        public DateTime? CumsFechaModificacion { get; set; }
    }
}
