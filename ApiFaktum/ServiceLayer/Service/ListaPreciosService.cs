using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla lista de precios
    /// </summary>
    public class ListaPreciosService : IListaPreciosService
    {
        private readonly IListaPreciosRepository objListaPreciosRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objListaPreciosRepository"></param>
        /// <returns></returns>
        public ListaPreciosService(IListaPreciosRepository _objListaPreciosRepository)
        {
            this.objListaPreciosRepository = _objListaPreciosRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la lista de precios de una sucursal cliente
        /// </summary>
        /// <param name="idSucursalCliente"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarListaPreciosSucursalesCliente(int idSucursalCliente)
        {
            return objListaPreciosRepository.ConsultarListaPreciosSucursalesCliente(idSucursalCliente);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearListaPrecio(ListaPrecioDto objModel)
        {
            return objListaPreciosRepository.CrearListaPrecio(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarListaPrecio(ListaPrecioDto objModel)
        {
            return objListaPreciosRepository.ActualizarListaPrecio(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una lista de precios
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarListaPrecio(ListaPrecioDto objModel)
        {
            return objListaPreciosRepository.EliminarListaPrecio(objModel);
        }
    }
}
