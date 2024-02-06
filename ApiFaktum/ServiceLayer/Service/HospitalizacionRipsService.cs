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
    public class HospitalizacionRipsService : IHospitalizacionRipsService
    {
        private readonly IHospitalizacionRipsRepository objHospitalizacionRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objHospitalizacionRipsRepository"></param>
        /// <returns></returns>
        public HospitalizacionRipsService(IHospitalizacionRipsRepository _objHospitalizacionRipsRepository)
        {
            this.objHospitalizacionRipsRepository = _objHospitalizacionRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarHospitalizacionRips()
        {
            return objHospitalizacionRipsRepository.ConsultarHospitalizacionRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearHospitalizacionRips(HospitalizacionRipsDto objModel)
        {
            return objHospitalizacionRipsRepository.CrearHospitalizacionRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarHospitalizacionRips(HospitalizacionRipsDto objModel)
        {
            return objHospitalizacionRipsRepository.ActualizarHospitalizacionRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarHospitalizacionRips(HospitalizacionRipsDto objModel)
        {
            return objHospitalizacionRipsRepository.EliminarHospitalizacionRips(objModel);
        }
    }
}
