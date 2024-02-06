using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class OtroServicioRipsService : IOtroServicioRipsService
    {
        private readonly IOtroServicioRipsRepository objOtroServicioRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objOtroServicioRipsRepository"></param>
        /// <returns></returns>
        public OtroServicioRipsService(IOtroServicioRipsRepository _objOtroServicioRipsRepository)
        {
            this.objOtroServicioRipsRepository = _objOtroServicioRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarOtroServicioRips()
        {
            return objOtroServicioRipsRepository.ConsultarOtroServicioRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearOtroServicioRips(OtroServicioRipsDto objModel)
        {
            return objOtroServicioRipsRepository.CrearOtroServicioRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarOtroServicioRips(OtroServicioRipsDto objModel)
        {
            return objOtroServicioRipsRepository.ActualizarOtroServicioRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarOtroServicioRips(OtroServicioRipsDto objModel)
        {
            return objOtroServicioRipsRepository.EliminarOtroServicioRips(objModel);
        }
    }
}
