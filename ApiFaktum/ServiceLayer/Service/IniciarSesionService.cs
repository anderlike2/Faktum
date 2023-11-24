using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class IniciarSesionService : IIniciarSesionService
    {
        private readonly IIniciarSesionRepository objRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objRepository"></param>
        /// <returns></returns>
        public IniciarSesionService(IIniciarSesionRepository _objRepository)
        {
            this.objRepository = _objRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ValidarLogin(LoginModel objModel)
        {
            return objRepository.ValidarLogin(objModel);
        }
    }
}
