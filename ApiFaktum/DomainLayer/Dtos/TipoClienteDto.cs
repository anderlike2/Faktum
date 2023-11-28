namespace DomainLayer.Dtos
{
    public class TipoClienteDto : BaseDto
    {
        public int TiclCodigo { get; set; }
        public string? TiclNombre { get; set; }

        //Referencias
        public List<EmpresaDto>? TiclEmpresas { get; set; }
        public List<ClienteDto>? TiclClientes { get; set; }
    }
}
