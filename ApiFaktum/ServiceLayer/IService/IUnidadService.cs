using DomainLayer.Dtos;
using DomainLayer.Models;
namespace ServiceLayer.IService
{
    public interface IUnidadService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las unidades por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarUnidadesEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearUnidad(UnidadDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarUnidad(UnidadDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarUnidad(UnidadDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar unidad por id
        /// </summary>
        /// <param name="idUnidad"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarUnidadId(int idUnidad);
    }
}
