using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class ListaPrecioProductoDto : BaseDto
    {
        public ListaPrecioDto? LproListaPrecio { get; set; }
        public ProductoDto? LproProducto { get; set; }
        public decimal? LproValor { get; set; }
        public decimal? LproDescuento { get; set; }

        //Referencias para consultas
        public int LproListaPrecioId { get; set; }
        public int LproProductoId { get; set; }
        public int LproListaPrecioAnteriorId { get; set; }
    }
}
