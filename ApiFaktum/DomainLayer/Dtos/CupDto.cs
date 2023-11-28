namespace DomainLayer.Dtos
{
    public class CupDto : BaseDto
    {
        public string? CupsCodigo { get; set; }
        public string? CupsNombre { get; set; }

        //Referencias
        public List<ProductoDto>? CupsProductos { get; set; }
    }
}
