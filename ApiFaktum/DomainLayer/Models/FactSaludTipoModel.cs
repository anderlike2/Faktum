using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FactSaludTipoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FasaCodigo { get; set; }
        public string? FasaNombre { get; set; }
        public bool? FasaEstado { get; set; }
        public DateTime? FasaFechaCreacion { get; set; }
        public DateTime? FasaFechaModificacion { get; set; }
    }
}
