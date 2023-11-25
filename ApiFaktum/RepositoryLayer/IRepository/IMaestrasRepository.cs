using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de las tablas maestras
    /// </summary>
    public interface IMaestrasRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las tablas maestras
        /// </summary>
        /// <param name="tipoClase"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaMaestra(string tipoClase);
    }
}
