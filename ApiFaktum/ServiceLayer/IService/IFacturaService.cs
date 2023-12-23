using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de la tabla Factura
    /// </summary>
    public interface IFacturaService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una factura
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearFactura(CrearFacturaDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de un detalle factura
        /// </summary>
        /// <param name="objModel"></param>
        /// <param name="idFactura"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearDetalleFactura(List<DetalleFactDto> objModel, int idFactura);
    }
}
