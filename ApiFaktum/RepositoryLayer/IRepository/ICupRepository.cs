using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de la tabla Cups
    /// </summary>
    public interface ICupRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla cup por coincidencia
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarCupPorCoincidencia(string filtro);
    }
}
