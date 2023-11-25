namespace DomainLayer.Dtos
{
    public class CoberturaDto
    {
        public int CobeCodigo { get; set; }
        public string? CobeNombre { get; set; }
        public bool? CobeEstado { get; set; }
        public DateTime? CobeFechaCreacion { get; set; }
        public DateTime? CobeFechaModificacion { get; set; }
    }
}
