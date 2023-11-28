namespace DomainLayer.Dtos
{
    public class MonedaDto : BaseDto
    {
        public int MoneCodigo { get; set; }
        public string? MoneNombre { get; set; }

        //Referencias
        public List<FacturaDto>? MoneFacturas { get; set; }
    }
}
