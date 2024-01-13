using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class EmpresaDto : BaseDto
    {
        public int EmprFactContador { get; set; }
        public string? EmprCelular { get; set; }
        public string? EmprCiuu { get; set; }        
        public string? EmprContacto { get; set; }
        public int EmprDiasPago { get; set; }
        public string? EmprDireccion { get; set; }
        public string? EmprDv { get; set; }       
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
        public string? EmprRepLegal { get; set; }        
        public string? EmprTelefono { get; set; }        
        public string? EmprHabilitacion { get; set; }
        public string? EmprLogo { get; set; }

        //Referencias
        public int EmprTipoClienteId { get; set; }
        public int EmprTipoIdId { get; set; }
        public int EmprRespTributId { get; set; }
        public int EmprRegimenId { get; set; }
        public int EmprRespFiscalId { get; set; }
        public int EmprClasJuridicaId { get; set; }
        public int EmprCiudadId { get; set; }
        public int EmprDeptoId { get; set; }
    }
}
