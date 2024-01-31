using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla lista de precios por producto
    /// </summary>
    public class ListaPrecioProductoService : IListaPrecioProductoService
    {
        private readonly IListaPrecioProductoRepository objListaPrecioProductoRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objListaPrecioProductoRepository"></param>
        /// <returns></returns>
        public ListaPrecioProductoService(IListaPrecioProductoRepository _objListaPrecioProductoRepository)
        {
            this.objListaPrecioProductoRepository = _objListaPrecioProductoRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearListaPrecioProducto(List<ListaPrecioProductoDto> objModel)
        {
            Result oRespuesta = new Result();

            foreach (ListaPrecioProductoDto item in objModel)
            {
                Task<Result> informacionListaProducto = objListaPrecioProductoRepository.ConsultarListaPrecioProductoPorFiltros(item);
                ListaPrecioProductoDto? listaProductoCompleto = (ListaPrecioProductoDto)informacionListaProducto.Result.Data;
                if (listaProductoCompleto == null)
                {
                    await objListaPrecioProductoRepository.CrearListaPrecioProducto(item);
                }
            }

            oRespuesta.Success = true;
            oRespuesta.Message = Constantes.msjRegGuardado;
            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarListaPrecioProducto(ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new Result();

            if (objModel.LproListaPrecioId.Equals(objModel.LproListaPrecioAnteriorId))
            {
                return objListaPrecioProductoRepository.ActualizarListaPrecioProducto(objModel);
            }
            else
            {
                Task<Result> informacionListaProducto = objListaPrecioProductoRepository.ConsultarListaPrecioProductoPorFiltros(objModel);
                ListaPrecioProductoDto? listaProductoCompleto = (ListaPrecioProductoDto)informacionListaProducto.Result.Data;
                if (listaProductoCompleto == null)
                {
                    return objListaPrecioProductoRepository.ActualizarListaPrecioProducto(objModel);
                }
                else
                {
                    oRespuesta.Success = false;
                    oRespuesta.Message = Constantes.msjListaPrecioProductoExiste;
                    return Task.FromResult(oRespuesta);
                }
            }            
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por lista de precios
        /// </summary>
        /// <param name="idListaPrecio"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarProductosListaPrecioId(int idListaPrecio)
        {
            return objListaPrecioProductoRepository.ConsultarProductosListaPrecioId(idListaPrecio);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para eliminar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarListaPrecioProducto(ListaPrecioProductoDto objModel)
        {
            return objListaPrecioProductoRepository.EliminarListaPrecioProducto(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por id
        /// </summary>
        /// <param name="idListaPrecioProducto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarListaPrecioProductoPorId(int idListaPrecioProducto)
        {
            return objListaPrecioProductoRepository.ConsultarListaPrecioProductoPorId(idListaPrecioProducto);
        }
    }
}
