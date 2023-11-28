
namespace DomainLayer.Dtos
{
    public class TipoCupDto : BaseDto
    {
        public int TicuCodigo { get; set; }
        public string? TicuNombre { get; set; }

        //Referencias
        public List<ProductoDto>? TicuProductos { get; set; }
    }
}
