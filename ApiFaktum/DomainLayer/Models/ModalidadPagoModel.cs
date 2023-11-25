using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ModalidadPagoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MopaCodigo { get; set; }
        public string? MopaNombre { get; set; }
        public bool? MopaEstado { get; set; }
        public DateTime? MopaFechaCreacion { get; set; }
        public DateTime? MopaFechaModificacion { get; set; }
    }
}
