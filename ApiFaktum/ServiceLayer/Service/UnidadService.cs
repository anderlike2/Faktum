using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla unidad
    /// </summary>
    public class UnidadService : IUnidadService
    {
        private readonly IUnidadRepository objUnidadRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUnidadRepository"></param>
        /// <returns></returns>
        public UnidadService(IUnidadRepository _objUnidadRepository)
        {
            this.objUnidadRepository = _objUnidadRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las unidades por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarUnidadesEmpresa(int idEmpresa)
        {
            return objUnidadRepository.ConsultarUnidadesEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearUnidad(UnidadDto objModel)
        {
            return objUnidadRepository.CrearUnidad(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarUnidad(UnidadDto objModel)
        {
            return objUnidadRepository.ActualizarUnidad(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una unidad
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarUnidad(UnidadDto objModel)
        {
            return objUnidadRepository.EliminarUnidad(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar unidad por id
        /// </summary>
        /// <param name="idUnidad"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarUnidadId(int idUnidad)
        {
            return objUnidadRepository.ConsultarUnidadId(idUnidad);
        }
    }
}
