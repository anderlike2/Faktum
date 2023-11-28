namespace DomainLayer.Dtos
{
    public class EstadoDianFacturaDto : BaseDto
    {
        public string? EsfaCodigo { get; set; }
        public string? EsfaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? EsfaFacturas { get; set; }
    }
}
