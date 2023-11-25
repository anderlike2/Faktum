namespace DomainLayer.Dtos
{
    public class CondicionVentaDto
    {
        public int CoveCodigo { get; set; }
        public string? CoveNombre { get; set; }
        public bool? CoveEstado { get; set; }
        public DateTime? CoveFechaCreacion { get; set; }
        public DateTime? CoveFechaModificacion { get; set; }
    }
}
