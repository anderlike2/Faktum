using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla resolucion
    /// </summary>
    public interface IResolucionService
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
    }
}
