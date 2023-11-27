namespace DomainLayer.Dtos
{
    public class RespTributariaDto : BaseDto
    {
        public int RetrCodigo { get; set; }
        public string? RetrNombre { get; set; }

        //Referencias
        public List<EmpresaDto>? RetrEmpresas { get; set; }
    }
}
