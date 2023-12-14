using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla centro de costo
    /// </summary>
    public class CentroCostoService : ICentroCostoService
    {
        private readonly ICentroCostoRepository objCentroCostoRepository;
        private readonly ISucursalRepository objSucursalRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objCentroCostoRepository"></param>
        /// <param name="_objSucursalRepository"></param>
        /// <returns></returns>
        public CentroCostoService(ICentroCostoRepository _objCentroCostoRepository, ISucursalRepository _objSucursalRepository)
        {
            this.objCentroCostoRepository = _objCentroCostoRepository;
            this.objSucursalRepository = _objSucursalRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los centros de costo
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarCentrosCostoEmpresa(int idEmpresa)
        {
            return objCentroCostoRepository.ConsultarCentrosCostoEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearCentroCosto(CentroCostoDto objModel)
        {
            return objCentroCostoRepository.CrearCentroCosto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarCentroCosto(CentroCostoDto objModel)
        {
            return objCentroCostoRepository.ActualizarCentroCosto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para eliminar un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarCentroCosto(CentroCostoDto objModel)
        {
            return objCentroCostoRepository.EliminarCentroCosto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el centro de costo por id
        /// </summary>
        /// <param name="idCentroCosto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarCentroCostoId(int idCentroCosto)
        {
            return objCentroCostoRepository.ConsultarCentroCostoId(idCentroCosto);
        }
    }
}
