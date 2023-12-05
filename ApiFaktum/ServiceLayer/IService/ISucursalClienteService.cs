using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla sucursalcliente
    /// </summary>
    public interface ISucursalClienteService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las sucursales de un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarSucursalesCliente(int idCliente);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearSucursalCliente(SucursalClienteDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarSucursalCliente(SucursalClienteDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarSucursalCliente(SucursalClienteDto objModel);
    }
}
