using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla Otros productos
    /// </summary>
    public class OtroProductoService : IOtroProductoService
    {
        private readonly IOtroProductoRepository otroProductoRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_otroProductoRepository"></param>
        /// <returns></returns>
        public OtroProductoService(IOtroProductoRepository _otroProductoRepository)
        {
            this.otroProductoRepository = _otroProductoRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los otros productos por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarOtrosProductosEmpresa(int idEmpresa)
        {
            return otroProductoRepository.ConsultarOtrosProductosEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearOtroProducto(OtroProductoDto objModel)
        {
            return otroProductoRepository.CrearOtroProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarOtroProducto(OtroProductoDto objModel)
        {
            return otroProductoRepository.ActualizarOtroProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarOtroProducto(OtroProductoDto objModel)
        {
            return otroProductoRepository.EliminarOtroProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el otro producto por id
        /// </summary>
        /// <param name="idOtroProducto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarOtroProductoId(int idOtroProducto)
        {
            return otroProductoRepository.ConsultarOtroProductoId(idOtroProducto);
        }
    }
}
