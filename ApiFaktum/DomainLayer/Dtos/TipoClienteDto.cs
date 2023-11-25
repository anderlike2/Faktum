namespace DomainLayer.Dtos
{
    public class TipoClienteDto
    {
        public int TiclCodigo { get; set; }
        public string? TiclNombre { get; set; }
        public bool? TiclEstado { get; set; }
        public DateTime? TiclFechaCreacion { get; set; }
        public DateTime? TiclFechaModificacion { get; set; }
    }
}
