using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Sebastian Cardona
    /// Interfaz para el manejo de la tabla usuario
    /// </summary>
    public interface IUsuarioSaludRipsService
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
        /// Metodo para crear un UsuarioSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>

        Task<Result> CrearUsuarioSaludRips(UsuarioSaludRipsDto objModel);

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Metodo para actualizar un UsuarioSaludRips
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
