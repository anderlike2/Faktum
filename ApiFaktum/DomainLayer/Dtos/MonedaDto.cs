namespace DomainLayer.Dtos
{
    public class MonedaDto
    {
        public int MoneCodigo { get; set; }
        public string? MoneNombre { get; set; }
        public bool? MoneEstado { get; set; }
        public DateTime? MoneFechaCreacion { get; set; }
        public DateTime? MoneFechaModificacion { get; set; }
    }
}
