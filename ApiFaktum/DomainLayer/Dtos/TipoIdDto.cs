namespace DomainLayer.Dtos
{
    public class TipoIdDto
    {
        public int TiidCodigo { get; set; }
        public string? TiidNombre { get; set; }
        public bool? TiidEstado { get; set; }
        public DateTime? TiidFechaCreacion { get; set; }
        public DateTime? TiidFechaModificacion { get; set; }
    }
}
