using DomainLayer.Dtos;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface IProcedimientoRipsService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los UsuarioSaludRips de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarProcedimientoRips();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un UsuarioSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>

        Task<Result> CrearProcedimientoRips(ProcedimientoRipsDto objModel);

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Metodo para actualizar un UsuarioSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarProcedimientoRips(ProcedimientoRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarProcedimientoRips(ProcedimientoRipsDto objModel);
    }
}
