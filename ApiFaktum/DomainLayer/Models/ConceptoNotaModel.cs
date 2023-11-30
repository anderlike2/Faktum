using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ConceptoNotaModel : BaseEntity
    {
        [Required]
        public string? ConoCodigo { get; set; }
        [Required]
        public string? ConoNombre { get; set; }
        [Required]
        public string? ConoTipoNota { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<NotaDebitoModel>? ConoNotasDebito { get; set; }
        [Required]
        public virtual ICollection<NotaCreditoModel>? ConoNotasCredito { get; set; }
    }
}
