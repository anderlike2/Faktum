using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Dtos
{
    public class HospitalizacionRipsDto : BaseDto
    {
        public int? HoRiId { get; set; }
        public string? HoRiUsuariosRips { get; set; }
        public string? HoRiViaIngreso { get; set; }
        public DateTime? HoRiFechaInicioAtencion { get; set; }
        public string? HoRiNumAutoriza { get; set; }
        public string? HoRiCausaMotivoAtencion { get; set; }
        public string? HoRiCodigoDiagPrincipal { get; set; }
        public string? HoRiCodigoDiagRel1 { get; set; }
        public string? HoRiCodigoDiagRel2 { get; set; }
        public string? HoRiCodigoDiagRel3 { get; set; }
        public string? HoRiCodComplicacion { get; set; }
        public string? HoRiConDestUsuarioOe { get; set; }
        public string? UrRiCodDiagMuerte { get; set; }
        public DateTime? UrRiFechaEgreso { get; set; }
    }
}
