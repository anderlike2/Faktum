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
    public class ConsultaRipsService : IConsultaRipsService
    {
        private readonly IConsultaRipsRepository objConsultaRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objClienteRepository"></param>
        /// <returns></returns>
        public ConsultaRipsService(IConsultaRipsRepository _objConsultaRipsRepository)
        {
            this.objConsultaRipsRepository = _objConsultaRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarConsultaRips()
        {
            return objConsultaRipsRepository.ConsultarConsultaRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearConsultaRips(ConsultaRipsDto objModel)
        {
            return objConsultaRipsRepository.CrearConsultaRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarConsultaRips(ConsultaRipsDto objModel)
        {
            return objConsultaRipsRepository.ActualizarConsultaRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarConsultaRips(ConsultaRipsDto objModel)
        {
            return objConsultaRipsRepository.EliminarConsultaRips(objModel);
        }
    }
}
