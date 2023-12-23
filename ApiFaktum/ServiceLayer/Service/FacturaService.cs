using Commun;
using DomainLayer.Dtos;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.IService;

namespace ServiceLayer.Service
{
    public class FacturaService : IFacturaService
    {
        private readonly IFacturaRepository objFacturaRepository;
        private readonly IDetalleFacturaRepository objDetalleFacturaRepository;

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Constructor por defecto
        /// </summary>
        /// <param name="_objFacturaRepository"></param>
        /// <returns></returns>
        public FacturaService(IFacturaRepository _objFacturaRepository, IDetalleFacturaRepository _objDetalleFacturaRepository)
        {
            this.objFacturaRepository = _objFacturaRepository;
            this.objDetalleFacturaRepository = _objDetalleFacturaRepository;
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de una factura
        /// </summary>
        /// <param name="objModel"></param>
        /// <returns>Task<Result></returns>
        public Task<Result> CrearFactura(CrearFacturaDto objModel)
        {
            Result oRespuesta = new Result();

            Task<Result> facturaInsertada = objFacturaRepository.CrearFactura(objModel.Factura);
            int factura = (int)facturaInsertada.Result.Data;
            if (factura > 0)
            {
                return CrearDetalleFactura(objModel.DetalleFactura, factura);
            }
            else
            {
                oRespuesta.Success = false;
                oRespuesta.Message = Constantes.msjFacturaNoInsertada;
                return Task.FromResult(oRespuesta);
            }            
        }

        /// <summary>
        /// Katary
        /// Anderson Benavides
        /// Metodo para crear informacion de un detalle factura
        /// </summary>
        /// <param name="objModel"></param>
        /// <param name="idFactura"></param>
        /// <returns>Task<Result></returns>
        public async Task<Result> CrearDetalleFactura(List<DetalleFactDto> objModel, int idFactura)
        {
            Result oRespuesta = new();

            foreach (DetalleFactDto item in objModel)
            {
                item.DetaFacturaId = idFactura;
                await objDetalleFacturaRepository.CrearDetalleFactura(item);
            }

            oRespuesta.Success = true;
            oRespuesta.Message = Constantes.msjRegGuardado;
            return await Task.FromResult(oRespuesta);
        }
    }
}
