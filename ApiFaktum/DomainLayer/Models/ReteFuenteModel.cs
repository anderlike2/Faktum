using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ReteFuenteModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReteCodigo { get; set; }
        [Required]
        public string? ReteNombre { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? RetePorcentaje { get; set; }
        [Required]
        public bool? ReteEstado { get; set; }
        [Required]
        public DateTime? ReteFechaCreacion { get; set; }
        public DateTime? ReteFechaModificacion { get; set; }
    }
}
