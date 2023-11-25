namespace DomainLayer.Dtos
{
    public class IumDto
    {
        public int IumCodigo { get; set; }
        public string? IumNombre { get; set; }
        public string? IumUnidad { get; set; }
        public bool? IumEstado { get; set; }
        public DateTime? IumFechaCreacion { get; set; }
        public DateTime? IumFechaModificacion { get; set; }
    }
}
