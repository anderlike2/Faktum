using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProcedimientoRips
    {
        public int? PrRiId { get; set; }
        public string? PrRiPrestador { get; set; }
        public string? PriUsuarioRips { get; set; }
        public DateTime? PrRiFechaCons { get; set; }
        public int? PrRiIdMPres { get; set; }
        public string? PrRiNUmAutoriza { get; set; }
        public string? PrRiDetaBorrador { get; set; }
        public string? PrRiViaIngresoUsuario { get; set; }
        public string? PrRiCodCups { get; set; }
        public string? PrRiModGrServAtencion { get; set; }
        public string? PrRiGrupoServicios { get; set; }
        public string? PrRiCodigoServicios { get; set; }
        public string? PrRiFinalidadConsulta { get; set; }
        public int? PrRiTipoIdMedico { get; set; }
        public string? PrRiNumDocMedico { get; set; }
        public string? PrRiCodigoDiagPrincipal { get; set; }
        public string? PrRiCodigoDiagRel { get; set; }
        public string? PrRiComplicacion { get; set; }
        public string? PrRiValorProcedimiento { get; set; }
        public string? PrRiTipoPagoModerador { get; set; }
        public string? PrRiValorPagoModerador { get; set; }
        public string? PrRiNumFactPagoMod { get; set; }

    }
}
