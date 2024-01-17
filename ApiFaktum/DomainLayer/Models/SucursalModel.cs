using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class SucursalModel : BaseEntity
    {
        [Required]
        public string? SucuDepto { get; set; }
        [Required]
        public string? SucuCelular { get; set; }
        [Required]
        public string? SucuCiudad { get; set; }
        [Required]
        public string? SucuCodigo { get; set; }
        [Required]
        public string? SucuContacto { get; set; }
        [Required]
        public string? SucuDireccion { get; set; }
        [Required]
        public int SucuEstadoOperacion { get; set; }
        [Required]
        public string? SucuHabilitacion { get; set; }
        [Required]
        public string? SucuLeyendaFactura { get; set; }
        [Required]
        public string? SucuLeyendaNotaCredito { get; set; }
        [Required]
        public string? SucuLeyendaNotaDebito { get; set; }
        [Required]
        public string? SucuListPrecio { get; set; }
        [Required]
        public string? SucuMail { get; set; }
        [Required]
        public string? SucuNombre { get; set; }
        [Required]
        public string? SucuObservaciones { get; set; }
        [Required]
        public int SucuPrincipal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? SucuReteIca { get; set; }
        [Required]
        public string? SucuTelefono { get; set; }
        public string? SucuCentroCosto { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? SucuEmpresa { get; set; }
        [Required]
        public virtual FormatoImpresionModel? SucuFormatoImpresion { get; set; }
        [Required]
        public virtual ICollection<ResolucionSucursalModel>? SucuResoluciones { get; set; }

        //Para creacion de datos mediante FK
        public virtual int SucuEmpresaId { get; set; }
        public virtual int SucuFormatoImpresionId { get; set; }
    }
}
