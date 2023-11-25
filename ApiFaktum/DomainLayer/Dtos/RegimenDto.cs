namespace DomainLayer.Dtos
{
    public class RegimenDto
    {
        public int RegiCodigo { get; set; }
        public string? RegiNombre { get; set; }
        public bool? RegiEstadoOperacion { get; set; }
        public bool? RegiEstado { get; set; }
        public DateTime? RegiFechaCreacion { get; set; }
        public DateTime? RegiFechaModificacion { get; set; }
    }
}
