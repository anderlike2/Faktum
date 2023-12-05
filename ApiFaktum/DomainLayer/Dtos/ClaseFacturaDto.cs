
namespace DomainLayer.Dtos
{
    public class ClaseFacturaDto : BaseDto
    {
        public string? ClfaCodigo { get; set; }
        public string? ClfaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? ClfaFacturas { get; set; }
    }
}
