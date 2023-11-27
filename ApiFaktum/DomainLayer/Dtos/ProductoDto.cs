using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class ProductoDto : BaseDto
    {
        public string? ProdCodigo { get; set; }
        public int ProdListaPrecio { get; set; }
        public string? ProdMarca { get; set; }
        public string? ProdModelo { get; set; }
        public string? ProdNombreFactura { get; set; }
        public string? ProdNombreTecnico { get; set; }
        public string? ProdUnidadHomologa { get; set; }
        public decimal ProdValor { get; set; }

        //Referencias
        public CentroCostoDto? ProdCentroCosto { get; set; }
        public ReteFuenteDto? ProdCodReteFuente { get; set; }
        public CumDto? ProdCum { get; set; }
        public CupDto? ProdCup { get; set; }
        public EmpresaDto? ProdEmpresa { get; set; }
        public IumDto? ProdIum { get; set; }
        public TipoCupDto? ProdTipoCup { get; set; }
        public ImpuestoDto? ProdTipoImpuesto { get; set; }
        public TipoArchivoRipsDto? ProdTipoRips { get; set; }
        public UnidadDto? ProdUnidad { get; set; }
    }
}
