using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla lista precios por producto
    /// </summary>
    public interface IListaPrecioProductoService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearListaPrecioProducto(List<ListaPrecioProductoDto> objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarListaPrecioProducto(ListaPrecioProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por lista de precios
        /// </summary>
        /// <param name="idListaPrecio"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarProductosListaPrecioId(int idListaPrecio);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para eliminar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarListaPrecioProducto(ListaPrecioProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por id
        /// </summary>
        /// <param name="idListaPrecioProducto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarListaPrecioProductoPorId(int idListaPrecioProducto);
    }
}
