using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla resoluciones y sucursales
    /// </summary>
    public interface IResolucionSucursalRepository
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
