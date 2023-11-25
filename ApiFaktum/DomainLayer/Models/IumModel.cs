using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class IumModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IumCodigo { get; set; }
        [Required]
        public string? IumNombre { get; set; }
        [Required]
        public string? IumUnidad { get; set; }
        [Required]
        public bool? IumEstado { get; set; }
        [Required]
        public DateTime? IumFechaCreacion { get; set; }
        public DateTime? IumFechaModificacion { get; set; }
    }
}
