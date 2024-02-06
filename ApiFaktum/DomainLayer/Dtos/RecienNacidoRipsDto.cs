using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Dtos
{
    public class RecienNacidoRipsDto : BaseDto
    {
        public int? RnRiId { get; set; }
        public string? RnRiPrestador { get; set; }
        public string? RnUsuarioRips { get; set; }
        public string? RnRiTipoRNid { get; set; }
        public DateTime? RnRiFechaNac { get; set; }
        public string? RnRiEdadGestacional { get; set; }
        public string? RnRiRoConsPreNatal { get; set; }
        public string? RnRiSexo { get; set; }
        public string? RnRiPeso { get; set; }
        public string? RnRiCodigoDiagPrincipal { get; set; }
        public string? RnRiConDestUsuarioE { get; set; }
        public string? RnRiCodDiagMuerte { get; set; }
        public string? RnRiFechaEgreso { get; set; }
    }
}
