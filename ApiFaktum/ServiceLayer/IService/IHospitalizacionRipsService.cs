using DomainLayer.Dtos;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface IHospitalizacionRipsService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los UsuarioSaludRips de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarHospitalizacionRips();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un UsuarioSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>

        Task<Result> CrearHospitalizacionRips(HospitalizacionRipsDto objModel);

        /// <summary>
        /// Katary
        /// Sebastian Cardona
        /// Metodo para actualizar un UsuarioSaludRips
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarHospitalizacionRips(HospitalizacionRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarHospitalizacionRips(HospitalizacionRipsDto objModel);
    }
}
