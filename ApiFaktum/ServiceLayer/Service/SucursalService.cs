using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla sucursal
    /// </summary>
    public class SucursalService : ISucursalService
    {
        private readonly ISucursalRepository objSucursalRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objEmpresaRepository"></param>
        /// <returns></returns>
        public SucursalService(ISucursalRepository _objSucursalRepository)
        {
            this.objSucursalRepository = _objSucursalRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las sucursales de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarSucursalesEmpresa(int idEmpresa)
        {
            return objSucursalRepository.ConsultarSucursalesEmpresa(idEmpresa);
        }
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearSucursal(SucursalDto objModel)
        {
            return objSucursalRepository.CrearSucursal(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarSucursal(SucursalDto objModel)
        {
            return objSucursalRepository.ActualizarSucursal(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para eliminar una sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarSucursal(SucursalDto objModel)
        {
            return objSucursalRepository.EliminarSucursal(objModel);
        }
    }
}
