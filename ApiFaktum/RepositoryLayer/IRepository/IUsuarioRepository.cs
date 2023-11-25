﻿using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla usuario
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar el usuario
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarUsuario(UsuarioFiltroDto objModel);
    }
}