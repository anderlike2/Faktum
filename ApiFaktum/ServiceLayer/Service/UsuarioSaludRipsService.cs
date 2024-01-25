using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class UsuarioSaludRipsService : IUsuarioSaludRipsService
    {
        private readonly IUsuarioSaludRipsRepository objUsuarioSaludRipsRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objClienteRepository"></param>
        /// <returns></returns>
        public UsuarioSaludRipsService(IUsuarioSaludRipsRepository _objUsuarioSaludRipsRepository)
        {
            this.objUsuarioSaludRipsRepository = _objUsuarioSaludRipsRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los clientes de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarUsuarioSaludRips()
        {
            return objUsuarioSaludRipsRepository.ConsultarUsuarioSaludRips();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearUsuarioSaludRips(UsuarioSaludRipsDto objModel)
        {
            return objUsuarioSaludRipsRepository.CrearUsuarioSaludRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ActualizarUsuarioSaludRips(UsuarioSaludRipsDto objModel)
        {
            return objUsuarioSaludRipsRepository.ActualizarUsuarioSaludRips(objModel);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> EliminarUsuarioSaludRips(UsuarioSaludRipsDto objModel)
        {
            return objUsuarioSaludRipsRepository.EliminarUsuarioSaludRips(objModel);
        }

    }
}
