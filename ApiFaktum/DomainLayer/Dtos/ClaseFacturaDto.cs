namespace DomainLayer.Dtos
{
    public class ClaseFacturaDto
    {
        public int ClfaCodigo { get; set; }
        public string? ClfaNombre { get; set; }
        public bool? ClfaEstado { get; set; }
        public DateTime? ClfaFechaCreacion { get; set; }
        public DateTime? ClfaFechaModificacion { get; set; }
    }
}
