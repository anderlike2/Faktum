using AutoMapper;
using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla otros productos
    /// </summary>
    public class OtroProductoRepository : IOtroProductoRepository
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
        public OtroProductoRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            objContext = _objContext;
            mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los otros productos por empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarOtrosProductosEmpresa(int idEmpresa)
        {
            Result oRespuesta = new Result();
            List<OtroProductoModel>? lstResult = new List<OtroProductoModel>();

            try
            {
                lstResult =
                    await objContext.OtrosProductos.Where(x => x.Estado == 1 && x.OtprEmpresa.Id.Equals(idEmpresa)).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<OtroProductoDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<OtroProductoDto>();
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
        /// Metodo para crear un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearOtroProducto(OtroProductoDto objModel)
        {
            Result oRespuesta = new();

            try
            {
                objModel.FechaCreacion = DateTime.UtcNow.ToLocalTime();

                await objContext.AddAsync(mapper.Map<OtroProductoModel>(objModel));
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
        /// Metodo para actualizar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ActualizarOtroProducto(OtroProductoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objModel.FechaModificacion = DateTime.UtcNow.ToLocalTime();

                objContext.Update(mapper.Map<OtroProductoModel>(objModel));
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
        /// Metodo para borrar un otro producto
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> EliminarOtroProducto(OtroProductoDto objModel)
        {
            Result oRespuesta = new Result();

            try
            {
                objContext.OtrosProductos.Remove(mapper.Map<OtroProductoModel>(objModel));
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
        /// Metodo para consultar el otro producto por id
        /// </summary>
        /// <param name="idOtroProducto"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarOtroProductoId(int idOtroProducto)
        {
            Result oRespuesta = new Result();
            OtroProductoModel? result = new OtroProductoModel();

            try
            {
                result =
                    await objContext.OtrosProductos.FirstOrDefaultAsync(x => x.Id.Equals(idOtroProducto));

                oRespuesta.Success = true;
                if (result != null)
                {

                    oRespuesta.Data = mapper.Map<OtroProductoDto>(result);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<OtroProductoDto>();
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
