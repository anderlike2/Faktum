namespace DomainLayer.Dtos
{
    public class ImpuestoDto
    {
        public int ImpuCodigo { get; set; }
        public string? ImpuNombre { get; set; }
        public bool? ImpuEstadoOperacion { get; set; }
        public string? ImpuOperacion { get; set; }
        public decimal? ImpuPorcentaje { get; set; }
        public bool? ImpuEstado { get; set; }
        public DateTime? ImpuFechaCreacion { get; set; }
        public DateTime? ImpuFechaModificacion { get; set; }
    }
}
