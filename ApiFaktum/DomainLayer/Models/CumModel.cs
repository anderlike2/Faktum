using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CumModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CumsCodigo { get; set; }
        [Required]
        public string? CumsNombre { get; set; }
        [Required]
        public int CumsConsecutivo { get; set; }
        [Required]
        public string? CumsExpediente { get; set; }
        [Required]
        public bool? CumsEstado { get; set; }
        [Required]
        public DateTime? CumsFechaCreacion { get; set; }
        public DateTime? CumsFechaModificacion { get; set; }
    }
}
