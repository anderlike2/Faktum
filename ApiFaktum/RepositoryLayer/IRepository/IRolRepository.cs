using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla rol
    /// </summary>
    public interface IRolRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los roles por usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarRolesUsuario(int idUsuario);
    }
}
