﻿using DomainLayer.Dtos;
using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla centro de costo
    /// </summary>
    public interface ICentroCostoService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los centros de costo de una empresa
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarCentrosCostoEmpresa(int idEmpresa);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearCentroCosto(CentroCostoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarCentroCosto(CentroCostoDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un centro de costo
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarCentroCosto(CentroCostoDto objModel);
    }
}
