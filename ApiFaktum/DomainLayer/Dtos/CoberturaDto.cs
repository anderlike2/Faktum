using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class CoberturaDto : BaseDto
    {
        public int CobeCodigo { get; set; }
        public string? CobeNombre { get; set; }

        //Referencias
        public List<FacturaDto>? CobeFacturas { get; set; }
    }
}
