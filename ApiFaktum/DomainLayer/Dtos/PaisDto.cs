namespace DomainLayer.Dtos
{
    public class PaisDto
    {
        public int PaisCodigo { get; set; }
        public string? PaisNombre { get; set; }
        public bool? PaisEstado { get; set; }
        public DateTime? PaisFechaCreacion { get; set; }
        public DateTime? PaisFechaModificacion { get; set; }
    }
}
