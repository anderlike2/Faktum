using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class ProductoModel : BaseEntity
    {
        [Required]
        public string? ProdCodigo { get; set; }
        [Required]
        public string? ProdMarca { get; set; }
        [Required]
        public string? ProdModelo { get; set; }
        [Required]
        public string? ProdNombreFactura { get; set; }
        [Required]
        public string? ProdNombreTecnico { get; set; }
        [Required]
        public string? ProdUnidadHomologa { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdValor { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdPorcReteFuente { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdPorcIva { get; set; }

        //Referencias
        [Required]
        public virtual CentroCostoModel? ProdCentroCosto { get; set; }  
        public virtual CumModel? ProdCum { get; set; }
        public virtual CupModel? ProdCup { get; set; }
        [Required]
        public virtual EmpresaModel? ProdEmpresa { get; set; }
        public virtual IumModel? ProdIum { get; set; }
        [Required]
        public virtual TipoCupModel? ProdTipoCup { get; set; }
        [Required]
        public virtual ImpuestoModel? ProdTipoImpuesto { get; set; }
        [Required]
        public virtual TipoArchivoRipsModel? ProdTipoRips { get; set; }
        [Required]
        public virtual UnidadModel? ProdUnidad { get; set; }     
        public virtual OtroProductoModel? ProdOtroProducto { get; set; }

        //Referencias para consultas FK
        public virtual int ProdCentroCostoId { get; set; }
        public virtual int? ProdCumId { get; set; }
        public virtual int? ProdCupId { get; set; }
        public virtual int ProdEmpresaId { get; set; }
        public virtual int? ProdIumId { get; set; }
        public virtual int ProdTipoCupId { get; set; }
        public virtual int ProdTipoImpuestoId { get; set; }
        public virtual int ProdTipoRipsId { get; set; }
        public virtual int ProdUnidadId { get; set; }
        public virtual int? ProdOtroProductoId { get; set; }
    }
}
