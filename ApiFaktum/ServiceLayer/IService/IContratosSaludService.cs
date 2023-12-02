using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla contratoscliente
    /// </summary>
    public interface IContratosSaludService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los contratos de un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarContratosSaludCliente(int idCliente);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearContratoSalud(ContratoSaludDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarContratoSalud(ContratoSaludDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un contrato de salud
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarContratoSalud(ContratoSaludDto objModel);
    }
}
