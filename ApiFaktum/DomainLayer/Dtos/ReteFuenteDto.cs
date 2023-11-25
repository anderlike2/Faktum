namespace DomainLayer.Dtos
{
    public class ReteFuenteDto
    {
        public int ReteCodigo { get; set; }
        public string? ReteNombre { get; set; }
        public decimal? RetePorcentaje { get; set; }
        public bool? ReteEstado { get; set; }
        public DateTime? ReteFechaCreacion { get; set; }
        public DateTime? ReteFechaModificacion { get; set; }
    }
}
