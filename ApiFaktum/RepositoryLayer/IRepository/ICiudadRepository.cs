﻿using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interface para el manejo de la tabla Ciudad
    /// </summary>
    public interface ICiudadRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTabla();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la ciudades de un departamento
        /// </summary>
        /// <param name="idDepto"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarCiudadesDepto(int idDepto);
    }
}
