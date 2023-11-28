using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class ResolucionDto : BaseDto
    {
        public string? ResoAnio { get; set; }
        public long ResoConsActual { get; set; }
        public long ResoConsFinal { get; set; }
        public long ResoConsInicial { get; set; }
        public int ResoEstadoOperacion { get; set; }
        public DateTime ResoFecheExpide { get; set; }
        public string? ResoPrefijo { get; set; }
        public DateTime ResoVigencia { get; set; }

        //Referencias
        public NumeracionResolucionDto? ResoNumeracionResolucion { get; set; }
        public EmpresaDto? ResoEmpresa { get; set; }
        public SucursalDto? ResoSucursal { get; set; }
        public TipoDocElectrDto? ResoTipoDoc { get; set; }
    }
}
