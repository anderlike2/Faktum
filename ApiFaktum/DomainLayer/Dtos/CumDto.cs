namespace DomainLayer.Dtos
{
    public class CumDto : BaseDto
    {
        public int CumsCodigo { get; set; }
        public string? CumsNombre { get; set; }
        public int CumsConsecutivo { get; set; }
        public string? CumsExpediente { get; set; }

        //Referencias
        public List<ProductoDto>? CumsProductos { get; set; }
    }
}
