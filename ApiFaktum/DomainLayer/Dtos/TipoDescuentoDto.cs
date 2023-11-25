namespace DomainLayer.Dtos
{
    public class TipoDescuentoDto
    {
        public int TideCodigo { get; set; }
        public string? TideNombre { get; set; }
        public bool? TideEstado { get; set; }
        public DateTime? TideFechaCreacion { get; set; }
        public DateTime? TideFechaModificacion { get; set; }
    }
}
