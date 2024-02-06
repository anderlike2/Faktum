using DomainLayer.Dtos;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.IRepository
{
    public interface IMedicamentosRipsRepository
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar los UsuarioSaludRips de una empresa
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarMedicamentosRips();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> CrearMedicamentosRips(MedicamentosRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para actualizar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ActualizarMedicamentosRips(MedicamentosRipsDto objModel);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para borrar un cliente
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        Task<Result> EliminarMedicamentosRips(MedicamentosRipsDto objModel);
    }
}
