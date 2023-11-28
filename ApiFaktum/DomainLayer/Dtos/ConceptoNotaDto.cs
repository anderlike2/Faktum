using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class ConceptoNotaDto : BaseDto
    {
        public int ConoCodigo { get; set; }
        public string? ConoNombre { get; set; }

        //Referencias
        public List<NotaDebitoDto>? ConoNotasDebito { get; set; }
        public List<NotaCreditoDto>? ConoNotasCredito { get; set; }
    }
}
