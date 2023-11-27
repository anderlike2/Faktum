using DomainLayer.Models;

namespace ServiceLayer.IService
{
    /// <summary>
    /// Anderson Benavides
    /// Interfaz para el manejo de las tablas maestras
    /// </summary>
    public interface IMaestrasService
    {
        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar las tablas maestras
        /// </summary>
        /// <param name="tipoClase"></param>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaMaestra(string tipoClase);

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Retefuente
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaRetefuente();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Cum
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaCum();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Regimen
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaRegimen();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Ium
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaIum();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de ClasJuridica
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaClasJuridica();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Impuesto
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaImpuesto();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Ciudad
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaCiudad();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de NumeracionResolucion
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaNumeracionResolucion();

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Depto
        /// </summary>
        /// <returns>Task<Result></returns>
        Task<Result> ConsultarTablaDepto();
    }
}
