
namespace DomainLayer.Dtos
{
    public class CrearDetalleFacturaDto
    {
        public int IdFactura { get; set; }
        public List<DetalleFactDto>? DetalleFactura { get; set; }
    }
}
