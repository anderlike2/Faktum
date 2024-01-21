namespace DomainLayer.Dtos
{
    public class ListaPrecioProducto : BaseDto
    {
        public string? Codigo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Nombre { get; set; }
        public decimal? Valor { get; set; }
        public decimal? PorcReteFuente { get; set; }
        public decimal? PorcIva { get; set; }
        public decimal? Descuento { get; set; }
        public bool EsListaPrecio { get; set; }
    }
}
