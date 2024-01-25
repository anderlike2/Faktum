using DomainLayer.Dtos;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.IRepository
{
    public interface IUsuarioSaludRipsRepository
    {

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los UsuarioSaludRips de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarUsuarioSaludRips();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearUsuarioSaludRips(UsuarioSaludRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarUsuarioSaludRips(UsuarioSaludRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarUsuarioSaludRips(UsuarioSaludRipsDto objModel);
    }
}
