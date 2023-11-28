using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class NotaDebitoModel : BaseEntity
    {
        [Required]
        public long NodbFactura { get; set; }
        [Required]
        public string? NodbMotivo { get; set; }
        [Required]
        public string? NodbNumero { get; set; }
        [Required]
        public long NodbValor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal NodbValorIva { get; set; }

        //Referencias
        [Required]
        public virtual ConceptoNotaModel? NodbConceptoNota { get; set; }
        [Required]
        public virtual EmpresaModel? NodbEmpresa { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? NodbFacturas { get; set; }
    }
}
