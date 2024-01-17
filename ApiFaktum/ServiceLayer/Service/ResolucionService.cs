using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla resolucion
    /// </summary>
    public class ResolucionService : IResolucionService
    {
        private readonly IResolucionRepository objResolucionRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objResolucionRepository"></param>
        /// <returns></returns>
        public ResolucionService(IResolucionRepository _objResolucionRepository)
        {
            this.objResolucionRepository = _objResolucionRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las resoluciones de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarResolucionesEmpresa(int idEmpresa)
        {
            return objResolucionRepository.ConsultarResolucionesEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearResolucion(ResolucionDto objModel)
        {
            return objResolucionRepository.CrearResolucion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarResolucion(ResolucionDto objModel)
        {
            return objResolucionRepository.ActualizarResolucion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una resolucion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarResolucion(ResolucionDto objModel)
        {
            return objResolucionRepository.EliminarResolucion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la resolucion por id
        /// </summary>
        /// <param name="idResolucion"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarResolucionId(int idResolucion)
        {
            return objResolucionRepository.ConsultarResolucionId(idResolucion);
        }
    }
}
