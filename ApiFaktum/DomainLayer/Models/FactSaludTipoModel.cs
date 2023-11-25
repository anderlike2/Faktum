using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FactSaludTipoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FasaCodigo { get; set; }
        [Required]
        public string? FasaNombre { get; set; }
        [Required]
        public bool? FasaEstado { get; set; }
        [Required]
        public DateTime? FasaFechaCreacion { get; set; }
        public DateTime? FasaFechaModificacion { get; set; }
    }
}
