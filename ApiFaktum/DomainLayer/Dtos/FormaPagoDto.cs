namespace DomainLayer.Dtos
{
    public class FormaPagoDto
    {
        public int FopaCodigo { get; set; }
        public string? FopaNombre { get; set; }
        public bool? FopaEstado { get; set; }
        public DateTime? FopaFechaCreacion { get; set; }
        public DateTime? FopaFechaModificacion { get; set; }
    }
}
