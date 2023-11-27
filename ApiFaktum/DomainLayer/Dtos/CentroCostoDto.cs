namespace DomainLayer.Dtos
{
    public class CentroCostoDto : BaseDto
    {
        public string? CcosCodigo { get; set; }
        public string? CcosNombre { get; set; }

        //Referencias
        public EmpresaDto? CcosEmpresa { get; set; }
        public List<ProductoDto>? CcosProductos { get; set; }
    }
}
