
namespace DomainLayer.Dtos
{
    public class TipoArchivoRipsDto
    {
        public int ArriCodigo { get; set; }
        public string? ArriNombre { get; set; }
        public bool? ArriEstado { get; set; }
        public DateTime? ArriFechaCreacion { get; set; }
        public DateTime? ArriFechaModificacion { get; set; }
    }
}
