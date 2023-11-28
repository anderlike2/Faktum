
namespace DomainLayer.Dtos
{
    public class TipoArchivoRipsDto : BaseDto
    {
        public int ArriCodigo { get; set; }
        public string? ArriNombre { get; set; }

        //Referencias
        public List<ProductoDto>? ArriProductos { get; set; }
    }
}
