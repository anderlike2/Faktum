using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla empresa
    /// </summary>
    public interface IEmpresaRepository
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
        /// Metodo para consultar las empresas por usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarEmpresasUsuario(int idUsuario);

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
