
namespace DomainLayer.Dtos
{
    public class TipoArchivoRipsDto : BaseDto
    {
        public string? ArriCodigo { get; set; }
        public string? ArriNombre { get; set; }

        //Referencias
        public List<ProductoDto>? ArriProductos { get; set; }
    }
}
