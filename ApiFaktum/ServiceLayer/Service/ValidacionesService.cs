using Commun;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    public class ValidacionesService : IValidacionesService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor
        /// </summary>
        /// <returns>Task<Result></returns>
        public ValidacionesService(){}

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los centros de costo de una empresa
        /// </summary>
        /// <param name="ex"></param>
        /// <returns>Task<Result></returns>
        public string ValidarEliminacionRegistro(Exception ex)
        {
            if(ex.InnerException != null)
            {
                if (ex.InnerException.Message.Contains(Constantes.fkProducto))
                    return Constantes.msjDependenciaProducto;
                if (ex.InnerException.Message.Contains(Constantes.fkSucursal))
                    return Constantes.msjDependenciaSucursal;
                if (ex.InnerException.Message.Contains(Constantes.fkResolucionSucursal))
                    return Constantes.msjDependenciaResolucionSucursal;
                if (ex.InnerException.Message.Contains(Constantes.fkListaPrecioProducto))
                    return Constantes.msjDependenciaListaPrecioProducto;
                if (ex.InnerException.Message.Contains(Constantes.fkContratoSalud))
                    return Constantes.msjDependenciaContratoSalud;
                else
                    return ex.Message + " - Inner: " + ex.InnerException;
            }
            else
                return ex.Message + " - Inner: " + ex.InnerException;
        }
    }
}
