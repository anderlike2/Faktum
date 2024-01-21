using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla producto
    /// </summary>
    public interface IProductoService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarProductosEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearProducto(ProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarProducto(ProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarProducto(ProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar un producto por id
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarProductoId(int idProducto);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las listas de precios de un producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarListasPreciosProducto(int idProducto);
    }
}
