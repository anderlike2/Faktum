namespace DomainLayer.Dtos
{
    public class CiudadDto
    {
        public int CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }
        public int CiudDepto { get; set; }
        public bool? CiudEstado { get; set; }
        public DateTime? CiudFechaCreacion { get; set; }
        public DateTime? CiudFechaModificacion { get; set; }
    }
}
