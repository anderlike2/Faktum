﻿using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de la tabla Depto
    /// </summary>
    public interface IDeptoRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTabla();
    }
}
