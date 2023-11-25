using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de las tablas maestras
    /// </summary>
    public interface IMaestrasService
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
