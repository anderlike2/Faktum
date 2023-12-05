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
    public class SucursalClienteService : ISucursalClienteService
    {
        private readonly ISucursalClienteRepository objSucursalClienteRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objSucursalClienteRepository"></param>
        /// <returns></returns>
        public SucursalClienteService(ISucursalClienteRepository _objSucursalClienteRepository)
        {
            this.objSucursalClienteRepository = _objSucursalClienteRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las sucursales de un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarSucursalesCliente(int idCliente)
        {
            return objSucursalClienteRepository.ConsultarSucursalesCliente(idCliente);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearSucursalCliente(SucursalClienteDto objModel)
        {
            return objSucursalClienteRepository.CrearSucursalCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarSucursalCliente(SucursalClienteDto objModel)
        {
            return objSucursalClienteRepository.ActualizarSucursalCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una sucursal de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarSucursalCliente(SucursalClienteDto objModel)
        {
            return objSucursalClienteRepository.EliminarSucursalCliente(objModel);
        }
    }
}
