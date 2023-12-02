using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ResolucionModel : BaseEntity
    {
        [Required]
        public string? ResoAnio { get; set; }
        [Required]
        public long ResoConsActual { get; set; }
        [Required]
        public long ResoConsFinal { get; set; }
        [Required]
        public long ResoConsInicial { get; set; }
        [Required]
        public int ResoEstadoOperacion { get; set; }
        [Required]
        public DateTime ResoFecheExpide { get; set; }
        [Required]
        public string? ResoPrefijo { get; set; }
        [Required]
        public DateTime ResoVigencia { get; set; }

        //Referencias
        [Required]
        public virtual NumeracionResolucionModel? ResoNumeracionResolucion { get; set; }
        [Required]
        public virtual EmpresaModel? ResoEmpresa { get; set; }
        [Required]
        public virtual SucursalModel? ResoSucursal { get; set; }
        [Required]
        public virtual TipoDocElectrModel? ResoTipoDoc { get; set; }

        //Referencias para consultas
        public virtual int ResoNumeracionResolucionId { get; set; }
        public virtual int ResoEmpresaId { get; set; }
        public virtual int ResoSucursalId { get; set; }
        public virtual int ResoTipoDocId { get; set; }
    }
}
