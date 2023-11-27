using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class EmpresaDto : BaseDto
    {
        public int EmprFactContador { get; set; }
        public string? EmprCelular { get; set; }
        public string? EmprCiudad { get; set; }
        public string? EmprCiuu { get; set; }
        public virtual ClasJuridicaDto? EmprClasJuridica { get; set; }
        public string? EmprContacto { get; set; }
        public string? EmprDepto { get; set; }
        public int EmprDiasPago { get; set; }
        public string? EmprDireccion { get; set; }
        public string? EmprDv { get; set; }
        public virtual RespFiscalDto? EmprRespFiscal { get; set; }
        public string? EmprFormatoImpr { get; set; }
        public string? EmprIdRepLegal { get; set; }
        public string? EmprLeyEnFactura { get; set; }
        public string? EmprLeyEnNotaCredito { get; set; }
        public string? EmprLeyEnNotaDebito { get; set; }
        public string? EmprLocalidad { get; set; }
        public string? EmprMail { get; set; }
        public string? EmprRecepcion { get; set; }
        public string? EmprNit { get; set; }
        public string? EmprNombre { get; set; }
        public string? EmprObservaciones { get; set; }
        public string? EmprPagWeb { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EmprPorcReteIca { get; set; }
        public virtual RegimenDto? EmprRegimen { get; set; }
        public string? EmprRepLegal { get; set; }
        public virtual RespTributariaDto? EmprRespTribut { get; set; }
        public string? EmprTelefono { get; set; }
        public virtual TipoClienteDto? EmprTipoCliente { get; set; }
        public virtual TipoIdDto? EmprTipoId { get; set; }
        public string? EmprHabilitacion { get; set; }
    }
}
