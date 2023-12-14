using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    public interface IFormatoImpresionService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los formatos de impresion por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarFormatosImpresionEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearFormatoImpresion(FormatoImpresionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarFormatoImpresion(FormatoImpresionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarFormatoImpresion(FormatoImpresionDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el formato de impresion por id
        /// </summary>
        /// <param name="idFormatoImpresion"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarFormatoImpresionId(int idFormatoImpresion);
    }
}
