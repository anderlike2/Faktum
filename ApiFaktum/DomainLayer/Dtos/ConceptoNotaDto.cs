namespace DomainLayer.Dtos
{
    public class ConceptoNotaDto
    {
        public int ConoCodigo { get; set; }
        public string? ConoNombre { get; set; }
        public bool? ConoEstado { get; set; }
        public DateTime? ConoFechaCreacion { get; set; }
        public DateTime? ConoFechaModificacion { get; set; }
    }
}
