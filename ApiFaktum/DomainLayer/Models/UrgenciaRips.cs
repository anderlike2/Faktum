using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UrgenciaRips : BaseEntity
    {
        [Required]
        [MaxLength(12)]
        public string? UrRiPrestador { get; set; }
        [Required]
        public DateTime? UrRiFechaConsulta { get; set; }
        [Required]
        [MaxLength(2)]
        public string? UrRiCausaMotivoAtencio { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? UrRiCodigoDiagPrincipal { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? URiCodigoDiagPrincipalE { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? UrRiCodigoDiagRel1 { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? UrRiCodigoDiagRel2 { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? UrRiCodigoDiagRel3 { get; set; }
        [Required]
        [MaxLength(2)]
        public string? UrRiConDestUsuarioE { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? UrRiCondDiagMuerte { get; set; }
        [Required]
        public DateTime? UrRiFechaEgreso { get; set; }
        [Required]
        [MaxLength(7)]
        public int? UrRiConsutivo { get; set; }


    }
}
