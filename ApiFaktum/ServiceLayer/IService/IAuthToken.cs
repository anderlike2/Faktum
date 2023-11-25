using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo del Token
    /// </summary>
    public interface IAuthToken
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para generar el token
        /// </summary>
        /// <param name="authModel"></param>
        /// <returns>string</returns>
        string GenerarToken(TokenModel authModel);
    }
}
