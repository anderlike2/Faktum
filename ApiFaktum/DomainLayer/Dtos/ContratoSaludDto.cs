namespace DomainLayer.Dtos
{
    public class ContratoSaludDto : BaseDto
    {
        public string? CosaContrato { get; set; }
        public string? CosaNitCliente { get; set; }
        public string? CosaPoliza { get; set; }

        //Referencias
        public ClienteDto? CosaClieId { get; set; }
        public CoberturaDto? CosaCobe { get; set; }
        public EmpresaDto? CosaEmpresa { get; set; }
        public ModalidadPagoDto? CosaMopa { get; set; }
    }
}
