using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla contratos cliente
    /// </summary>
    public class ContratosSaludClienteService : IContratosSaludClienteService
    {
        private readonly IContratosSaludClienteRepository objContratosSaludClienteRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContratosSaludClienteRepository"></param>
        /// <returns></returns>
        public ContratosSaludClienteService(IContratosSaludClienteRepository _objContratosSaludClienteRepository)
        {
            this.objContratosSaludClienteRepository = _objContratosSaludClienteRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los contratos de un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarContratosSaludCliente(int idCliente)
        {
            return objContratosSaludClienteRepository.ConsultarContratosSaludCliente(idCliente);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un contrato de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearContratoSaludCliente(ContratoSaludDto objModel)
        {
            return objContratosSaludClienteRepository.CrearContratoSaludCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un contrato de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarContratoSaludCliente(ContratoSaludDto objModel)
        {
            return objContratosSaludClienteRepository.ActualizarContratoSaludCliente(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un contrato de un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarContratoSaludCliente(ContratoSaludDto objModel)
        {
            return objContratosSaludClienteRepository.EliminarContratoSaludCliente(objModel);
        }
    }
}
