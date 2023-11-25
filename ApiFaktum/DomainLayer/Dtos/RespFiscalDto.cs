namespace DomainLayer.Dtos
{
    public class RespFiscalDto
    {
        public int RefiCodigo { get; set; }
        public string? RefiNombre { get; set; }
        public bool? RefiEstado { get; set; }
        public DateTime? RefiFechaCreacion { get; set; }
        public DateTime? RefiFechaModificacion { get; set; }
    }
}
