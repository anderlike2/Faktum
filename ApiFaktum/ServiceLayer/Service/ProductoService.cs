using Commun;
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
        private readonly IListaPreciosRepository objListaPreciosRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objProductoRepository"></param>
        /// <returns></returns>
        public ProductoService(IProductoRepository _objProductoRepository, IListaPreciosRepository _objListaPreciosRepository)
        {
            this.objProductoRepository = _objProductoRepository;
            this.objListaPreciosRepository = _objListaPreciosRepository;
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

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar un producto por id
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarProductoId(int idProducto)
        {
            return objProductoRepository.ConsultarProductoId(idProducto);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las listas de precios de un producto
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarListasPreciosProducto(int idProducto)
        {
            Result oRespuesta = new Result();

            try
            {
                List<ListaPrecioProducto> lstResultado = new List<ListaPrecioProducto>();
                Task<Result> informacionUsuario = objProductoRepository.ConsultarProductoId(idProducto);
                ProductoDto? infoProducto = (ProductoDto)informacionUsuario.Result.Data;
                lstResultado.Add(new ListaPrecioProducto
                {
                    Codigo = infoProducto.ProdCodigo,
                    Marca = infoProducto.ProdMarca,
                    Modelo = infoProducto.ProdModelo,
                    Nombre = infoProducto.ProdNombreTecnico,
                    Valor = infoProducto.ProdValor,
                    PorcReteFuente = infoProducto.ProdPorcReteFuente,
                    PorcIva = infoProducto.ProdPorcIva,
                    Descuento = 0,
                    EsListaPrecio = false
                });

                Task<Result> informacionListaPrecios = objListaPreciosRepository.ConsultarListaPrecioProducto(idProducto);
                List<ListaPrecioDto>? infoListaPrecios = (List<ListaPrecioDto>)informacionListaPrecios.Result.Data;

                foreach (ListaPrecioDto item in infoListaPrecios)
                {
                    lstResultado.Add(new ListaPrecioProducto
                    {
                        Codigo = item.LiprDescripcion,
                        Marca = string.Empty,
                        Modelo = string.Empty,
                        Nombre = item.LiprNombre,
                        Valor = item.LiprValor,
                        PorcReteFuente = 0,
                        PorcIva = 0,
                        Descuento = item.LiprDescuento,
                        EsListaPrecio = true
                    });
                }

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjConsultaExitosa;
                oRespuesta.Data = lstResultado;
            }
            catch(Exception e)
            {
                oRespuesta.Success = false;
                oRespuesta.Message = e.Message;
            }

            return Task.FromResult(oRespuesta);
        }
    }
}
