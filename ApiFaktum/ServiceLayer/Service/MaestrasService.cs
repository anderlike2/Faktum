using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de las tablas maestras
    /// </summary>
    public class MaestrasService : IMaestrasService
    {
        private readonly IMaestrasRepository objMaestrasRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objMaestrasRepository"></param>
        /// <returns></returns>
        public MaestrasService(IMaestrasRepository _objMaestrasRepository)
        {
            this.objMaestrasRepository = _objMaestrasRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="tipoClase"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaMaestra(string tipoClase)
        {
            return objMaestrasRepository.ConsultarTablaMaestra(tipoClase);
        }
    }
}
