using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla producto
    /// </summary>
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository objProductoRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objProductoRepository"></param>
        /// <returns></returns>
        public ProductoService(IProductoRepository _objProductoRepository)
        {
            this.objProductoRepository = _objProductoRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarProductosEmpresa(int idEmpresa)
        {
            return objProductoRepository.ConsultarProductosEmpresa(idEmpresa);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearProducto(ProductoDto objModel)
        {
            return objProductoRepository.CrearProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarProducto(ProductoDto objModel)
        {
            return objProductoRepository.ActualizarProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarProducto(ProductoDto objModel)
        {
            return objProductoRepository.EliminarProducto(objModel);
        }
    }
}
