namespace DomainLayer.Dtos
{
    public class ModalidadPagoDto : BaseDto
    {
        public string? MopaCodigo { get; set; }
        public string? MopaNombre { get; set; }

        //Referencias
        public List<ContratoSaludDto>? MopaContratosSalud { get; set; }
    }
}
