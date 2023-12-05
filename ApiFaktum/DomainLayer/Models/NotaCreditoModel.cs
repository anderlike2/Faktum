using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class NotaCreditoModel : BaseEntity
    {
        public long NocrFactura { get; set; }
        public string? NocrMotivo { get; set; }
        public string? NocrNumero { get; set; }
        public long NocrValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal NocrValorIva { get; set; }

        [Required]
        public virtual ConceptoNotaModel? NocrConceptoNota { get; set; }
        [Required]
        public virtual EmpresaModel? NocrEmpresa { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? NocrFacturas { get; set; }
    }
}
