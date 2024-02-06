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
    public class UrgenciaRipsService : IUrgenciaRipsService
    {
        private readonly IUrgenciaRipsRepository objUrgenciaRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objUrgenciaRipsRepository"></param>
        /// <returns></returns>
        public UrgenciaRipsService(IUrgenciaRipsRepository _objUrgenciaRipsRepository)
        {
            this.objUrgenciaRipsRepository = _objUrgenciaRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarUrgenciaRips()
        {
            return objUrgenciaRipsRepository.ConsultarUrgenciaRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearUrgenciaRips(UrgenciaRipsDto objModel)
        {
            return objUrgenciaRipsRepository.CrearUrgenciaRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarUrgenciaRips(UrgenciaRipsDto objModel)
        {
            return objUrgenciaRipsRepository.ActualizarUrgenciaRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarUrgenciaRips(UrgenciaRipsDto objModel)
        {
            return objUrgenciaRipsRepository.EliminarUrgenciaRips(objModel);
        }
    }
}
