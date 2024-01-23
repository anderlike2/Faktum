using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UrgenciaRips
    {
        public int? UrRiId { get; set; }
        public string? UrRiPrestador { get; set; }
        public string? UrRiUsuarioRips { get; set; }
        public DateTime? UrRiFechaCons { get; set; }
        public string? UrRiCausaMotivoAtencio { get; set; }
        public string? UrRiCodigoDiagPrincipal { get; set; }
        public string? URiCodigoDiagPrincipalE { get; set; }
        public string? UrRiCodigoDiagRel1 { get; set; }
        public string? UrRiCodigoDiagRel2 { get; set; }
        public string? UrRiCodigoDiagRel3 { get; set; }
        public string? UrRiConDestUsuarioE { get; set; }
        public string? UrRiCondDiagMuerte { get; set; }
        public string? UrRiFechaEgreso { get; set; }
    }
}
