using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    // <summary>
    /// Anderson Benavides
    /// Clase para el manejo de la tabla Resolucion Sucursal
    /// </summary>
    public class ResolucionSucursalService: IResolucionSucursalService
    {
        private readonly IResolucionSucursalRepository resolucionSucursalRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_resolucionSucursalRepository"></param>
        /// <returns></returns>
        public ResolucionSucursalService(IResolucionSucursalRepository _resolucionSucursalRepository)
        {
            this.resolucionSucursalRepository = _resolucionSucursalRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearResolucionSucursal(ResolucionSucursalDto objModel)
        {
            Result oRespuesta = new Result();
            //Validar el usuario en la empresa
            Task<Result> existeResolucion = resolucionSucursalRepository.ValidarResolucionSucursal(objModel);
            ResolucionSucursalDto? resol = (ResolucionSucursalDto)existeResolucion.Result.Data;
            if (resol == null)
            {
                return resolucionSucursalRepository.CrearResolucionSucursal(objModel);
            }
            else
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjResolucionSucursalExiste;
                return Task.FromResult(oRespuesta);
            }                
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarResolucionSucursal(ResolucionSucursalDto objModel)
        {
            Result oRespuesta = new Result();
            //Validar el usuario en la empresa
            Task<Result> existeResolucion = resolucionSucursalRepository.ValidarResolucionSucursal(objModel);
            ResolucionSucursalDto? resol = (ResolucionSucursalDto)existeResolucion.Result.Data;
            if (resol == null)
            {
                return resolucionSucursalRepository.ActualizarResolucionSucursal(objModel);
            }
            else
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjResolucionSucursalExiste;
                return Task.FromResult(oRespuesta);
            }
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la resolucion sucursal por id
        /// </summary>
        /// <param name="idResolucionSucursal"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarResolucionSucursalId(int idResolucionSucursal)
        {
            return resolucionSucursalRepository.ConsultarResolucionSucursalId(idResolucionSucursal);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar una resolucion sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarResolucionSucursal(ResolucionSucursalDto objModel)
        {
            return resolucionSucursalRepository.EliminarResolucionSucursal(objModel);
        }
    }
}
