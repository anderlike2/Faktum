namespace DomainLayer.Dtos
{
    public class FormaPagoDto : BaseDto
    {
        public int FopaCodigo { get; set; }
        public string? FopaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? FopaFacturas { get; set; }
    }
}
