using DomainLayer.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class ImpuestoDto : BaseDto
    {
        public int ImpuCodigo { get; set; }
        public string? ImpuNombre { get; set; }
        public int ImpuEstadoOperacion { get; set; }
        public string? ImpuOperacion { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ImpuPorcentaje { get; set; }

        //Referencias
        public List<ProductoDto>? ImpuProductos { get; set; }
        public List<DetalleFactDto>? ImpuDetFacturas { get; set; }
    }
}
