namespace DomainLayer.Dtos
{
    public class MonedaDto : BaseDto
    {
        public string? MoneCodigo { get; set; }
        public string? MoneNombre { get; set; }

        //Referencias
        public List<FacturaDto>? MoneFacturas { get; set; }
    }
}
