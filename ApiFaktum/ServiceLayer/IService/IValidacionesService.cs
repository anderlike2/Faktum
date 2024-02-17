using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de las validaciones y mensajes
    /// </summary>
    public interface IValidacionesService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los centros de costo de una empresa
        /// </summary>
        /// <param name="ex"></param>
        /// <returns>Task<Result></returns>
        string ValidarEliminacionRegistro(Exception ex);
    }
}
