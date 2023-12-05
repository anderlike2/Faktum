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
    /// Clase para el manejo de la tabla rol
    /// </summary>
    public class RolRepository : IRolRepository
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
        public RolRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los roles por usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarRolesUsuario(int idUsuario)
        {
            Result oRespuesta = new Result();
            List<RolModel>? lstResult = new List<RolModel>();

            try
            {
                lstResult = await (from rusu in objContext.RolUsuario
                                   join rol in objContext.Rol on rusu.RousRol.Id equals rol.Id
                                   where rusu.RousUsuario.Id == idUsuario
                                   select new RolModel
                                   {
                                       Id = rol.Id,
                                       RolCodigo = rol.RolCodigo,
                                       RolDescripcion = rol.RolDescripcion,
                                       Estado = rol.Estado,
                                       FechaCreacion = rol.FechaCreacion,
                                       FechaModificacion = rol.FechaModificacion
                                   }).ToListAsync();

                oRespuesta.Success = true;
                if (lstResult.Count > 0)
                {

                    oRespuesta.Data = mapper.Map<List<RolDto>>(lstResult);
                    oRespuesta.Message = Constantes.msjConsultaExitosa;
                }
                else
                {
                    oRespuesta.Data = new List<RolDto>();
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
