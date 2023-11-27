using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class UnidadDto : BaseDto
    {
        public string? UnidCodigoDian { get; set; }
        public string? UnidCodigo { get; set; }
        public string? UnidNombre { get; set; }

        //Referencias
        public EmpresaDto? UnidEmpresa { get; set; }
        public List<ProductoDto>? UnidProductos { get; set; }
        public List<DetalleFactDto>? UnidDetFacturas { get; set; }
    }
}
