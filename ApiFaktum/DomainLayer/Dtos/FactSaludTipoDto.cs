namespace DomainLayer.Dtos
{
    public class FactSaludTipoDto : BaseDto
    {
        public string? FasaCodigo { get; set; }
        public string? FasaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? FasaFacturas { get; set; }
    }
}
