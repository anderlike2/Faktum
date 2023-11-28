using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class NotaCreditoDto : BaseDto
    {
        public long NocrFactura { get; set; }
        public string? NocrMotivo { get; set; }
        public string? NocrNumero { get; set; }
        public long NocrValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal NocrValorIva { get; set; }

        //Referencias
        public ConceptoNotaDto? NocrConceptoNota { get; set; }
        public EmpresaDto? NocrEmpresa { get; set; }
        public List<FacturaDto>? NocrFacturas { get; set; }
    }
}
