namespace DomainLayer.Dtos
{
    public class TipoDocElectrDto
    {
        public int TidoCodigo { get; set; }
        public string? TidoNombre { get; set; }
        public bool? TidoEstado { get; set; }
        public DateTime? TidoFechaCreacion { get; set; }
        public DateTime? TidoFechaModificacion { get; set; }
    }
}
