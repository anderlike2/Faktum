namespace DomainLayer.Dtos
{
    public class EstadoDianFacturaDto
    {
        public int EsfaCodigo { get; set; }
        public string? EsfaNombre { get; set; }
        public bool? EsfaEstado { get; set; }
        public DateTime? EsfaFechaCreacion { get; set; }
        public DateTime? EsfaFechaModificacion { get; set; }
    }
}
