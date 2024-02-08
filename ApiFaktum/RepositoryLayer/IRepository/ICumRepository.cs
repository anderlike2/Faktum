using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de la tabla Cums
    /// </summary>
    public interface ICumRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTabla();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla cum por coincidencia
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarCumPorCoincidencia(string filtro);
    }
}
