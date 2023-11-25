using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ModalidadPagoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MopaCodigo { get; set; }
        [Required]
        public string? MopaNombre { get; set; }
        [Required]
        public bool? MopaEstado { get; set; }
        [Required]
        public DateTime? MopaFechaCreacion { get; set; }
        public DateTime? MopaFechaModificacion { get; set; }
    }
}
