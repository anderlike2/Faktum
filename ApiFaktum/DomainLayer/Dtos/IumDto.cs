namespace DomainLayer.Dtos
{
    public class IumDto : BaseDto
    {
        public int IumCodigo { get; set; }
        public string? IumNombre { get; set; }
        public string? IumUnidad { get; set; }

        public List<ProductoDto>? IumProductos { get; set; }
    }
}
