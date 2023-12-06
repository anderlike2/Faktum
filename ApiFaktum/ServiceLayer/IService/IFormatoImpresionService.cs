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
    }
}
