using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class ImpuestoDto
    {
        public int ImpuCodigo { get; set; }
        public string? ImpuNombre { get; set; }
        public bool? ImpuEstadoOperacion { get; set; }
        public string? ImpuOperacion { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? ImpuPorcentaje { get; set; }
        public bool? ImpuEstado { get; set; }
        public DateTime? ImpuFechaCreacion { get; set; }
        public DateTime? ImpuFechaModificacion { get; set; }
    }
}
