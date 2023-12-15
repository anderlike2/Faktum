using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla lista precios
    /// </summary>
    public interface IListaPreciosService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la lista de precios de una sucursal cliente
        /// </summary>
        /// <param name="idSucursalCliente"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarListaPreciosSucursalesCliente(int idSucursalCliente);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearListaPrecio(ListaPrecioDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarListaPrecio(ListaPrecioDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarListaPrecio(ListaPrecioDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la lista de precios por di
        /// </summary>
        /// <param name="idListaPrecio"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarListaPrecioId(int idListaPrecio);
    }
}
