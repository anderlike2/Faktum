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
    public class MedicamentosRipsService : IMedicamentosRipsService
    {
        private readonly IMedicamentosRipsRepository objMedicamentosRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objMedicamentosRipsRepository"></param>
        /// <returns></returns>
        public MedicamentosRipsService(IMedicamentosRipsRepository _objMedicamentosRipsRepository)
        {
            this.objMedicamentosRipsRepository = _objMedicamentosRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarMedicamentosRips()
        {
            return objMedicamentosRipsRepository.ConsultarMedicamentosRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearMedicamentosRips(MedicamentosRipsDto objModel)
        {
            return objMedicamentosRipsRepository.CrearMedicamentosRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarMedicamentosRips(MedicamentosRipsDto objModel)
        {
            return objMedicamentosRipsRepository.ActualizarMedicamentosRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarMedicamentosRips(MedicamentosRipsDto objModel)
        {
            return objMedicamentosRipsRepository.EliminarMedicamentosRips(objModel);
        }
    }
}
