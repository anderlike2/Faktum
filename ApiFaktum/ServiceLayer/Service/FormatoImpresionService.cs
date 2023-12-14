using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla formatos de impresion
    /// </summary>
    public class FormatoImpresionService : IFormatoImpresionService
    {
        private readonly IFormatoImpresionRepository objFormatoImpresionRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objFormatoImpresionRepository"></param>
        /// <returns></returns>
        public FormatoImpresionService(IFormatoImpresionRepository _objFormatoImpresionRepository)
        {
            this.objFormatoImpresionRepository = _objFormatoImpresionRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los formatos de impresion por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarFormatosImpresionEmpresa(int idEmpresa)
        {
            return objFormatoImpresionRepository.ConsultarFormatosImpresionEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearFormatoImpresion(FormatoImpresionDto objModel)
        {
            return objFormatoImpresionRepository.CrearFormatoImpresion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarFormatoImpresion(FormatoImpresionDto objModel)
        {
            return objFormatoImpresionRepository.ActualizarFormatoImpresion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un formato de impresion
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarFormatoImpresion(FormatoImpresionDto objModel)
        {
            return objFormatoImpresionRepository.EliminarFormatoImpresion(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el formato de impresion por id
        /// </summary>
        /// <param name="idFormatoImpresion"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarFormatoImpresionId(int idFormatoImpresion)
        {
            return objFormatoImpresionRepository.ConsultarFormatoImpresionId(idFormatoImpresion);
        }
    }
}
