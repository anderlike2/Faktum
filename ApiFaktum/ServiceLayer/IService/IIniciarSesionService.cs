using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la autenticacion
    /// </summary>
    public interface IIniciarSesionService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ValidarLogin(LoginModel objModel);
    }
}
