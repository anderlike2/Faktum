using DomainLayer.Dtos;
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

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una empresa
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearEmpresa(EmpresaDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una empresa
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarEmpresa(EmpresaDto objModel);
    }
}
