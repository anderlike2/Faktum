using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class SucursalDto : BaseDto
    {
        public string? SucuDepto { get; set; }
        public string? SucuCelular { get; set; }
        public string? SucuCiudad { get; set; }
        public string? SucuCodigo { get; set; }
        public string? SucuContacto { get; set; }
        public string? SucuDireccion { get; set; }
        public int SucuEstadoOperacion { get; set; }
        public string? SucuHabilitacion { get; set; }
        public string? SucuLeyendaFactura { get; set; }
        public string? SucuLeyendaNotaCredito { get; set; }
        public string? SucuLeyendaNotaDebito { get; set; }
        public string? SucuListPrecio { get; set; }
        public string? SucuMail { get; set; }
        public string? SucuNombre { get; set; }
        public string? SucuObservaciones { get; set; }
        public int SucuPrincipal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? SucuReteIca { get; set; }
        public string? SucuTelefono { get; set; }

        //Referencias
        public CentroCostoDto? SucuCentroCostos { get; set; }
        public EmpresaDto? SucuEmpresa { get; set; }
        public FormatoImpresionDto? SucuFormatoImpresion { get; set; }
    }
}
