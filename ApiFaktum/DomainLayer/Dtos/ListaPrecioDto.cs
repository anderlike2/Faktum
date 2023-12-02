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

        //Referencias para Consultas
        public int LiprEmpresaId { get; set; }
        public int LiprProductoId { get; set; }
        public int LiprSucursalClienteId { get; set; }
        public int LiprClienteId { get; set; }
    }
}
