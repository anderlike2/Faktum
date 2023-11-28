using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ModalidadPagoModel : BaseEntity
    {
        [Required]
        public int MopaCodigo { get; set; }
        [Required]
        public string? MopaNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ContratoSaludModel>? MopaContratosSalud { get; set; }
    }
}
