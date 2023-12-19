using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    public interface IOtroProductoRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los otros productos por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarOtrosProductosEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearOtroProducto(OtroProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarOtroProducto(OtroProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarOtroProducto(OtroProductoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el otro producto por id
        /// </summary>
        /// <param name="idOtroProducto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarOtroProductoId(int idOtroProducto);
    }
}
