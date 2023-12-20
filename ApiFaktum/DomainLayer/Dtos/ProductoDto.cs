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
        public int ProdCentroCostoId { get; set; }
        public int ProdCodReteFuenteId { get; set; }
        public int? ProdCumId { get; set; }
        public int? ProdCupId { get; set; }
        public int ProdEmpresaId { get; set; }
        public int? ProdIumId { get; set; }
        public int ProdTipoCupId { get; set; }
        public int ProdTipoImpuestoId { get; set; }
        public int ProdTipoRipsId { get; set; }
        public int ProdUnidadId { get; set; }
        public int? ProdOtroProductoId { get; set; }
    }
}
