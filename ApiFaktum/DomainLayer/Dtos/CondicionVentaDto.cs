namespace DomainLayer.Dtos
{
    public class CondicionVentaDto : BaseDto
    {
        public string? CoveCodigo { get; set; }
        public string? CoveNombre { get; set; }

        //Referencias
        public List<FacturaDto>? CoveFacturas { get; set; }
    }
}
