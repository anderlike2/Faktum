using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ImpuestoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImpuCodigo { get; set; }
        [Required]
        public string? ImpuNombre { get; set; }
        [Required]
        public bool? ImpuEstadoOperacion { get; set; }
        [Required]
        public string? ImpuOperacion { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? ImpuPorcentaje { get; set; }
        [Required]
        public bool? ImpuEstado { get; set; }
        [Required]
        public DateTime? ImpuFechaCreacion { get; set; }
        public DateTime? ImpuFechaModificacion { get; set; }
    }
}
