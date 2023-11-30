using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla cliente
    /// </summary>
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository objClienteRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objClienteRepository"></param>
        /// <returns></returns>
        public ClienteService(IClienteRepository _objClienteRepository)
        {
            this.objClienteRepository = _objClienteRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarClientesEmpresa(int idEmpresa)
        {
            return objClienteRepository.ConsultarClientesEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearCliente(ClienteDto objModel)
        {
            return objClienteRepository.CrearCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarCliente(ClienteDto objModel)
        {
            return objClienteRepository.ActualizarCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarCliente(ClienteDto objModel)
        {
            return objClienteRepository.EliminarCliente(objModel);
        }
    }
}
