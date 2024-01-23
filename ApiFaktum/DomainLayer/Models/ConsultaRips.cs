using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ConsultaRips
    {
        public int? CoRiId { get; set; }
        public string? CoRiPrestador { get; set; }
        public string? CoRiUsuarioRips { get; set; }
        public DateTime? CoRiFechaCons { get; set; }
        public string? CoRiNumAutoriza { get; set; }
        public string? CoRiDetaBorrador { get; set; }
        public string? CoRiCodCups { get; set; }
        public string? CoRiModGrSerAtencion { get; set; }
        public string? CoRiGrupoServicios { get; set; }
        public string? CoRiCodigoServicios { get; set; }
        public string? CoRiFinalidadConsulta { get; set; }
        public string? CoRiCausaMotivoAtencion { get; set; }
        public string? CoRiCodigoDiagPrincipal { get; set; }
        public string? CoRiCodigoDiagRel1 { get; set; }
        public string? CoRiCodigoDiagRel2 { get; set; }
        public string? CoRiCodigoDiagRel3 { get; set; }
        public string? CoRiTipoDiagPrincipal { get; set; }
        public int? CoRiTipoIdMedico { get; set; }
        public string? CoRiNummDocMedico { get; set; }
        public string? CoRiValorConsulta { get; set; }
        public string? CoRiTipoPagoModerador { get; set; }
        public string? CoRiValorPagoModerador { get; set; }
        public string? CoriNumFactPagoMod { get; set; }

    }
}
