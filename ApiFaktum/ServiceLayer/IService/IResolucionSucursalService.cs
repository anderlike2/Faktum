using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    // <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo del servicio la tabla resoluciones y sucursales
    /// </summary>
    public interface IResolucionSucursalService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearResolucionSucursal(ResolucionSucursalDto objModel);
    }
}
