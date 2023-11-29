using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de las tabla empresa
    /// </summary>
    public interface IEmpresaService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las empresas
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarEmpresas();
    }
}
