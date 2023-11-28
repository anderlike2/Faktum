using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class ListaPrecioDto : BaseDto
    {
        public string? LiprDescripcion { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiprDescuento { get; set; }
        public int LiprEstadoOperacion { get; set; }
        public string? LiprNombre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LiprValor { get; set; }

        //Referencias
        public EmpresaDto? LiprEmpresa { get; set; }
        public ProductoDto? LiprProducto { get; set; }
        public List<FacturaDto>? LiprFacturas { get; set; }
        public List<DetalleFactDto>? LiprDetFacturas { get; set; }
    }
}
