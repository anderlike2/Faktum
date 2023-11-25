using AutoMapper;
using DomainLayer.Dtos;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;

namespace RepositoryLayer.Repository
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la autenticacion
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
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
        public UsuarioRepository(ApplicationDbContext _objContext, IMapper _mapper)
        {
            this.objContext = _objContext;
            this.mapper = _mapper;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> ConsultarUsuario(UsuarioFiltroDto objModel)
        {
            Result oRespuesta = new Result();

            UsuarioModel? result = new UsuarioModel();
            UsuarioDto temp = new UsuarioDto();

            try
            {
                result = await objContext.Usuario.FirstOrDefaultAsync(x => x.UsuaUsuario.Equals(objModel.UsuaUsuario) && x.UsuaPassword.Equals(objModel.UsuaPassword) );

                if (result != null)
                {
                    temp = mapper.Map<UsuarioDto>(result);

                    oRespuesta.Success = true;
                    oRespuesta.Data = temp;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Message = ex.Message;
            }

            return oRespuesta;
        }
    }
}
