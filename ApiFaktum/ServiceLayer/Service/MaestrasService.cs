using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de las tablas maestras
    /// </summary>
    public class MaestrasService : IMaestrasService
    {
        private readonly IMaestrasRepository objMaestrasRepository;
        private readonly IReteFuenteRepository objReteFuenteRepository;
        private readonly ICumRepository objCumRepository;
        private readonly IRegimenRepository objRegimenRepository;
        private readonly IIumRepository objIumRepository;
        private readonly IClasJuridicaRepository objClasJuridicaRepository;
        private readonly IImpuestoRepository objImpuestoRepository;
        private readonly ICiudadRepository objCiudadRepository;
        private readonly IDeptoRepository objDeptoRepository;
        private readonly ICupRepository objCupRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objMaestrasRepository"></param>
        /// <param name="_objReteFuenteRepository"></param>
        /// <param name="_objCumRepository"></param>
        /// <param name="_objRegimenRepository"></param>
        /// <param name="_objIumRepository"></param>
        /// <param name="_objClasJuridicaRepository"></param>
        /// <param name="_objImpuestoRepository"></param>
        /// <param name="_objCiudadRepository"></param>
        /// <param name="_objCupRepository"></param>
        /// <param name="_obDeptoRepository"></param>
        /// <returns></returns>
        public MaestrasService(IMaestrasRepository _objMaestrasRepository, IReteFuenteRepository _objReteFuenteRepository, ICumRepository _objCumRepository, 
            IRegimenRepository _objRegimenRepository, IIumRepository _objIumRepository, IClasJuridicaRepository _objClasJuridicaRepository, 
            IImpuestoRepository _objImpuestoRepository, ICiudadRepository _objCiudadRepository,
            IDeptoRepository _obDeptoRepository, ICupRepository _objCupRepository)
        {
            this.objMaestrasRepository = _objMaestrasRepository;
            this.objReteFuenteRepository = _objReteFuenteRepository;
            this.objCumRepository = _objCumRepository;
            this.objRegimenRepository = _objRegimenRepository;
            this.objIumRepository = _objIumRepository;
            this.objClasJuridicaRepository = _objClasJuridicaRepository;
            this.objImpuestoRepository = _objImpuestoRepository;
            this.objCiudadRepository = _objCiudadRepository;
            this.objDeptoRepository = _obDeptoRepository;
            this.objCupRepository = _objCupRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para validar el login
        /// </summary>
        /// <param name="tipoClase"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaMaestra(string tipoClase)
        {
            return objMaestrasRepository.ConsultarTablaMaestra(tipoClase);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Retefuente
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaRetefuente()
        {
            return objReteFuenteRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Cum
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaCum()
        {
            return objCumRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Regimen
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaRegimen()
        {
            return objRegimenRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Ium
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaIum()
        {
            return objIumRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de ClaJuridica
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaClasJuridica()
        {
            return objClasJuridicaRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Impuesto
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaImpuesto()
        {
            return objImpuestoRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Ciudad
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaCiudad()
        {
            return objCiudadRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla de Depto
        /// </summary>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarTablaDepto()
        {
            return objDeptoRepository.ConsultarTabla();
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla cum por coincidencia
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarCumPorCoincidencia(string filtro)
        {
            return objCumRepository.ConsultarCumPorCoincidencia(filtro);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla cum por coincidencia
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarIumPorCoincidencia(string filtro)
        {
            return objIumRepository.ConsultarIumPorCoincidencia(filtro);
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para consultar la tabla cup por coincidencia
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> ConsultarCupPorCoincidencia(string filtro)
        {
            return objCupRepository.ConsultarCupPorCoincidencia(filtro);
        }
    }
}
