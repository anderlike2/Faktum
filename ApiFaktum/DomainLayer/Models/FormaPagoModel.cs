using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FormaPagoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FopaCodigo { get; set; }
        public string? FopaNombre { get; set; }
        public bool? FopaEstado { get; set; }
        public DateTime? FopaFechaCreacion { get; set; }
        public DateTime? FopaFechaModificacion { get; set; }
    }
}
