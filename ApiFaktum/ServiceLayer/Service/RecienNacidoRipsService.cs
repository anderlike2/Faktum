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
    public class RecienNacidoRipsService : IRecienNacidoRipsService
    {
        private readonly IRecienNacidoRipsRepository objRecienNacidoRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objRecienNacidoRipsRepository"></param>
        /// <returns></returns>
        public RecienNacidoRipsService(IRecienNacidoRipsRepository _objRecienNacidoRipsRepository)
        {
            this.objRecienNacidoRipsRepository = _objRecienNacidoRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarRecienNacidoRips()
        {
            return objRecienNacidoRipsRepository.ConsultarRecienNacidoRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearRecienNacidoRips(RecienNacidoRipsDto objModel)
        {
            return objRecienNacidoRipsRepository.CrearRecienNacidoRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarRecienNacidoRips(RecienNacidoRipsDto objModel)
        {
            return objRecienNacidoRipsRepository.ActualizarRecienNacidoRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarRecienNacidoRips(RecienNacidoRipsDto objModel)
        {
            return objRecienNacidoRipsRepository.EliminarRecienNacidoRips(objModel);
        }
    }
}
