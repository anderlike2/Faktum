
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class EmpresaModel : BaseEntity
    {
        [Required]
        public int EmprFactContador { get; set; }
        [Required]
        public string? EmprCelular { get; set; }
        [Required]
        public string? EmprCiudad { get; set; }
        public string? EmprCiuu { get; set; }        
        [Required]
        public string? EmprContacto { get; set; }
        [Required]
        public string? EmprDepto{ get; set; }
        [Required]
        public int EmprDiasPago { get; set; }
        [Required]
        public string? EmprDireccion { get; set; }
        [Required]
        public string? EmprDv{ get; set; }        
        [Required]
        public string? EmprFormatoImpr { get; set; }
        [Required]
        public string? EmprIdRepLegal{ get; set; }
        [Required]
        public string? EmprLeyEnFactura { get; set; }
        [Required]
        public string? EmprLeyEnNotaCredito{ get; set; }
        [Required]
        public string? EmprLeyEnNotaDebito { get; set; }
        public string? EmprLocalidad { get; set; }
        [Required]
        public string? EmprMail { get; set; }
        [Required]
        public string? EmprRecepcion { get; set; }
        [Required]
        public string? EmprNit { get; set; }
        [Required]
        public string? EmprNombre { get; set; }
        [Required]
        public string? EmprObservaciones { get; set; }
        [Required]
        public string? EmprPagWeb { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal EmprPorcReteIca { get; set; }        
        [Required]
        public string? EmprRepLegal { get; set; }        
        [Required]
        public string? EmprTelefono { get; set; }       
        [Required]
        public string? EmprHabilitacion { get; set; }

        //Referencias
        [Required]
        public virtual TipoClienteModel? EmprTipoCliente { get; set; }
        [Required]
        public virtual TipoIdModel? EmprTipoId { get; set; }
        [Required]
        public virtual RespTributariaModel? EmprRespTribut { get; set; }
        [Required]
        public virtual RegimenModel? EmprRegimen { get; set; }
        [Required]
        public virtual RespFiscalModel? EmprRespFiscal { get; set; }
        [Required]
        public virtual ClasJuridicaModel? EmprClasJuridica { get; set; }
        [Required]
        public virtual ICollection<ProductoModel>? EmprProductos { get; set; }
        [Required]
        public virtual ICollection<CentroCostoModel>? EmprCentroCostos { get; set; }
        [Required]
        public virtual ICollection<FormatoImpresionModel>? EmprFormatosImpresion { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? EmprFacturas { get; set; }
        [Required]
        public virtual ICollection<DetalleFactModel>? EmprDetFacturas { get; set; }

    }
}
