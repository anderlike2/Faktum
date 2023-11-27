namespace DomainLayer.Dtos
{
    public class RegimenDto : BaseDto
    {
        public int RegiCodigo { get; set; }
        public string? RegiNombre { get; set; }
        public int RegiEstadoOperacion { get; set; }
    }
}
