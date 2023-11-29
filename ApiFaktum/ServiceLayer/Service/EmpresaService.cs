using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla empresa
    /// </summary>
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository objEmpresaRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objEmpresaRepository"></param>
        /// <returns></returns>
        public EmpresaService(IEmpresaRepository _objEmpresaRepository)
        {
            this.objEmpresaRepository = _objEmpresaRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las empresas
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarEmpresas()
        {
            return objEmpresaRepository.ConsultarEmpresas();
        }
    }
}
