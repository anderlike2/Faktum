using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    public class ListaPrecioProductoRepository : IListaPrecioProductoRepository
    {
        private readonly ApplicationDbContext objContext;
        private readonly IMapper mapper;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objContext"></param>
        /// <param name="_mapper"></param>
        /// <returns></returns>
        public ListaPrecioProductoRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearListaPrecioProducto(ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<ListaPrecioProductoModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegGuardado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarListaPrecioProducto(ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<ListaPrecioProductoModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegActualizado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por lista de precios
        /// </summary>
        /// <param name="idListaPrecio"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarProductosListaPrecioId(int idListaPrecio)
        {
            Result oRespuesta = new Result();
            List<ListaPrecioProductoModel?> result = new List<ListaPrecioProductoModel?>();
            List<ListaPrecioProductoDto?> resultFinal = new List<ListaPrecioProductoDto?>();

            try
            {
                result =  await objContext.ListaPrecioProducto.Where(x => x.LproListaPrecioId.Equals(idListaPrecio)).Include(z => z.LproProducto).ToListAsync();

                oRespuesta.Success = true;
                if (result != null)
                {

                    //oRespuesta.Data = mapper.Map<ListaPrecioProductoDto>(result);
                    foreach (ListaPrecioProductoModel? item in result)
                    {
                        resultFinal.Add(new ListaPrecioProductoDto
                        {
                            Id = item.Id,
                            LproValor = item.LproValor,
                            LproDescuento = item.LproDescuento,
                            LproListaPrecioId = item.LproListaPrecioId,
                            LproProductoId = item.LproProductoId,
                            Estado = item.Estado,
                            FechaCreacion = item.FechaCreacion,
                            FechaModificacion = item.FechaModificacion,
                            LproProducto = new ProductoDto
                            {
                                Id = item.LproProducto.Id,
                                ProdCodigo = item.LproProducto.ProdCodigo,
                                ProdMarca = item.LproProducto.ProdMarca,
                                ProdNombreFactura = item.LproProducto.ProdNombreFactura,
                                ProdNombreTecnico = item.LproProducto.ProdNombreTecnico,
                                ProdUnidadHomologa = item.LproProducto.ProdUnidadHomologa,
                                ProdValor = item.LproProducto.ProdValor,
                                ProdPorcReteFuente = item.LproProducto.ProdPorcReteFuente,
                                ProdPorcIva = item.LproProducto.ProdPorcIva
                            }
                        });
                    }
                    oRespuesta.Data = resultFinal;
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ListaPrecioProductoDto>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por lista de precios
        /// </summary>
        /// <param name="objMode"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarListaPrecioProductoPorFiltros(ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new Result();

            ListaPrecioProductoModel? result = new ListaPrecioProductoModel();
            ListaPrecioProductoDto temp = new ListaPrecioProductoDto();

            try
            {
                result = await objContext.ListaPrecioProducto.AsNoTracking().
                    Where(x => x.LproProductoId.Equals(objModel.LproProductoId) && x.LproListaPrecioId.Equals(objModel.LproListaPrecioId)).FirstOrDefaultAsync();

                if (result != null)
                {
                    temp = mapper.Map<ListaPrecioProductoDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para eliminar una lista de precios por producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarListaPrecioProducto(ListaPrecioProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objContext.ListaPrecioProducto.Remove(mapper.Map<ListaPrecioProductoModel>(objModel));
                await objContext.SaveChangesAsync();

                oRespuesta.Success = true;
                oRespuesta.Message = Constantes.msjRegEliminado;
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos por id
        /// </summary>
        /// <param name="idListaPrecioProducto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarListaPrecioProductoPorId(int idListaPrecioProducto)
        {
            Result oRespuesta = new Result();

            ListaPrecioProductoModel? result = new ListaPrecioProductoModel();
            ListaPrecioProductoDto temp = new ListaPrecioProductoDto();

            try
            {
                result = await objContext.ListaPrecioProducto.AsNoTracking().
                    Where(x => x.Id.Equals(idListaPrecioProducto)).FirstOrDefaultAsync();

                if (result != null)
                {
                    temp = mapper.Map<ListaPrecioProductoDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                    oRespuesta.Message = Constantes.msjLoginCorrecto;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return oRespuesta;
        }
    }
}
