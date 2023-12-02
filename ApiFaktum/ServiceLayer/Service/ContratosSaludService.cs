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
    public class ContratosSaludService : IContratosSaludService
    {
        private readonly IContratosSaludRepository objContratosSaludRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContratosSaludRepository"></param>
        /// <returns></returns>
        public ContratosSaludService(IContratosSaludRepository _objContratosSaludRepository)
        {
            this.objContratosSaludRepository = _objContratosSaludRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los contratos de salud
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarContratosSaludCliente(int idCliente)
        {
            return objContratosSaludRepository.ConsultarContratosSaludCliente(idCliente);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearContratoSalud(ContratoSaludDto objModel)
        {
            return objContratosSaludRepository.CrearContratoSalud(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarContratoSalud(ContratoSaludDto objModel)
        {
            return objContratosSaludRepository.ActualizarContratoSalud(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarContratoSalud(ContratoSaludDto objModel)
        {
            return objContratosSaludRepository.EliminarContratoSalud(objModel);
        }
    }
}
