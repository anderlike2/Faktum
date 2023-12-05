
namespace DomainLayer.Dtos
{
    public class TipoCupDto : BaseDto
    {
        public string? TicuCodigo { get; set; }
        public string? TicuNombre { get; set; }

        //Referencias
        public List<ProductoDto>? TicuProductos { get; set; }
    }
}
