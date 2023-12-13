
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla ciudad
    /// </summary>
    public interface ICiudadService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la ciudades de un departamento
        /// </summary>
        /// <param name="idDepto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarCiudadesDepto(int idDepto);
    }
}
