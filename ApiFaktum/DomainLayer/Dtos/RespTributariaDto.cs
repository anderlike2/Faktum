
namespace DomainLayer.Dtos
{
    public class RespTributariaDto
    {
        public int RetrCodigo { get; set; }
        public string? RetrNombre { get; set; }
        public bool? RetrEstado { get; set; }
        public DateTime? RetrFechaCreacion { get; set; }
        public DateTime? RetrFechaModificacion { get; set; }
    }
}
