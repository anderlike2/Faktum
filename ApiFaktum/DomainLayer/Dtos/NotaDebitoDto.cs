using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class NotaDebitoDto : BaseDto
    {
        public long NodbFactura { get; set; }
        public string? NodbMotivo { get; set; }
        public string? NodbNumero { get; set; }
        public long NodbValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal NodbValorIva { get; set; }

        //Referencias
        public ConceptoNotaDto? NodbConceptoNota { get; set; }
        public EmpresaDto? NodbEmpresa { get; set; }
        public List<FacturaDto>? NodbFacturas { get; set; }
    }
}
