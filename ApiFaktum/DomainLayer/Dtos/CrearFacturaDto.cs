namespace DomainLayer.Dtos
{
    public class CrearFacturaDto
    {
        public FacturaDto? Factura { get; set; }
        public List<DetalleFactDto>? DetalleFactura { get; set; }
    }
}
