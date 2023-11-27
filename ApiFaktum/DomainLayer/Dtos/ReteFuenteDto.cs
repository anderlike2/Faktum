using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class ReteFuenteDto : BaseDto
    {
        public int ReteCodigo { get; set; }
        public string? ReteNombre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? RetePorcentaje { get; set; }

        //Referencias
        public List<ProductoDto>? ReteProductos { get; set; }
    }
}
