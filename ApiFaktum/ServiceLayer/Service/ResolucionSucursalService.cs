using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla Resolucion Sucursal
    /// </summary>
    public class ResolucionSucursalService: IResolucionSucursalService
    {
        private readonly IResolucionSucursalRepository resolucionSucursalRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_resolucionSucursalRepository"></param>
        /// <returns></returns>
        public ResolucionSucursalService(IResolucionSucursalRepository _resolucionSucursalRepository)
        {
            this.resolucionSucursalRepository = _resolucionSucursalRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearResolucionSucursal(ResolucionSucursalDto objModel)
        {
            return resolucionSucursalRepository.CrearResolucionSucursal(objModel);
        }
    }
}
