using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla resolucion
    /// </summary>
    public interface IResolucionRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las resoluciones de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarResolucionesEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearResolucion(ResolucionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarResolucion(ResolucionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarResolucion(ResolucionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la resolucion por id
        /// </summary>
        /// <param name="idResolucion"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarResolucionId(int idResolucion);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las resoluciones de una sucursal
        /// </summary>
        /// <param name="idSucursal"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarResolucionesSucursal(int idSucursal);
    }
}
