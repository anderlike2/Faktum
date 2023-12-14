using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla producto
    /// </summary>
    public class ProductoRepository : IProductoRepository
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
        public ProductoRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los productos de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarProductosEmpresa(int idEmpresa)
        {
            Result oRespuesta = new Result();
            List<ProductoModel>? lstResult = new List<ProductoModel>();

            try
            {
                lstResult =
                    await objContext.Producto.Where(x => x.Estado == 1 && x.ProdEmpresa.Id.Equals(idEmpresa)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<ProductoDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ProductoDto>();
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
        /// Metodo para crear un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearProducto(ProductoDto objModel)
        {
            Result oRespuesta = new();
            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<ProductoModel>(objModel));
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
        /// Metodo para actualizar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarProducto(ProductoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<ProductoModel>(objModel));
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
        /// Metodo para borrar un producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarProducto(ProductoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.Producto.Remove(mapper.Map<ProductoModel>(objModel));
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
        /// Metodo para consultar un producto por id
        /// </summary>
        /// <param name="idProducto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarProductoId(int idProducto)
        {
            Result oRespuesta = new Result();
            ProductoModel? result = new ProductoModel();

            try
            {
                result =
                    await objContext.Producto.FirstOrDefaultAsync(x => x.Id.Equals(idProducto));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<ProductoDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<ProductoDto>();
                    oRespuesta.Message = Constantes.msjNoHayRegistros;
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
