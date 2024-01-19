﻿using DomainLayer.Dtos;
using DomainLayer.Models;

namespace RepositoryLayer.IRepository
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de la tabla resoluciones y sucursales
    /// </summary>
    public interface IResolucionSucursalRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearResolucionSucursal(ResolucionSucursalDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarResolucionSucursal(ResolucionSucursalDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar informacion de una resolucion por sucursal
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ValidarResolucionSucursal(ResolucionSucursalDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la resolucion sucursal por id
        /// </summary>
        /// <param name="idResolucionSucursal"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarResolucionSucursalId(int idResolucionSucursal);
    }
}
