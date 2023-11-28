namespace DomainLayer.Dtos
{
    public class RespFiscalDto : BaseDto
    {
        public string? RefiCodigo { get; set; }
        public string? RefiNombre { get; set; }

        //Referencias
        public List<EmpresaDto>? RefiEmpresas { get; set; }
        public List<ClienteDto>? RefiClientes { get; set; }
    }
}
