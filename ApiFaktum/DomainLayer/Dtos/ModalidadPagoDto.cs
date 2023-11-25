namespace DomainLayer.Dtos
{
    public class ModalidadPagoDto
    {
        public int MopaCodigo { get; set; }
        public string? MopaNombre { get; set; }
        public bool? MopaEstado { get; set; }
        public DateTime? MopaFechaCreacion { get; set; }
        public DateTime? MopaFechaModificacion { get; set; }
    }
}
