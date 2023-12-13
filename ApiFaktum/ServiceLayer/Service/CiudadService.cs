using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla ciudad
    /// </summary>
    public class CiudadService : ICiudadService
    {
        private readonly ICiudadRepository objCiudadRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objCiudadRepository"></param>
        /// <returns></returns>
        public CiudadService(ICiudadRepository _objCiudadRepository)
        {
            this.objCiudadRepository = _objCiudadRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la ciudades de un departamento
        /// </summary>
        /// <param name="idDepto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarCiudadesDepto(int idDepto)
        {
            return objCiudadRepository.ConsultarCiudadesDepto(idDepto);
        }
    }
}
