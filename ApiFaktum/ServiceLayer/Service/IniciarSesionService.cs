using DomainLayer.Dtos;
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
        private readonly IUsuarioRepository objUsuarioRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUsuarioRepository"></param>
        /// <returns></returns>
        public IniciarSesionService(IUsuarioRepository _objUsuarioRepository)
        {
            this.objUsuarioRepository = _objUsuarioRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ValidarLogin(UsuarioFiltroDto objModel)
        {
            return objUsuarioRepository.ConsultarUsuario(objModel);
        }
    }
}
