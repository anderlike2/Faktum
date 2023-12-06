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
    }
}
