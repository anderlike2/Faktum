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
    public class ProcedimientoRipsService : IProcedimientoRipsService
    {
        private readonly IProcedimientoRipsRepository objProcedimientoRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objProcedimientoRipsRepository"></param>
        /// <returns></returns>
        public ProcedimientoRipsService(IProcedimientoRipsRepository _objProcedimientoRipsRepository)
        {
            this.objProcedimientoRipsRepository = _objProcedimientoRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarProcedimientoRips()
        {
            return objProcedimientoRipsRepository.ConsultarProcedimientoRips();
        }
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearProcedimientoRips(ProcedimientoRipsDto objModel)
        {
            return objProcedimientoRipsRepository.CrearProcedimientoRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarProcedimientoRips(ProcedimientoRipsDto objModel)
        {
            return objProcedimientoRipsRepository.ActualizarProcedimientoRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarProcedimientoRips(ProcedimientoRipsDto objModel)
        {
            return objProcedimientoRipsRepository.EliminarProcedimientoRips(objModel);
        }
    }
}
