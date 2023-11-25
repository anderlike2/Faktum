namespace DomainLayer.Dtos
{
    public class LocalidadDto
    {
        public int LocaCodigo { get; set; }
        public string? LocaNombre { get; set; }
        public bool? LocaEstado { get; set; }
        public DateTime? LocaFechaCreacion { get; set; }
        public DateTime? LocaFechaModificacion { get; set; }
    }
}
