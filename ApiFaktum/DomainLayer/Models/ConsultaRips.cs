using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ConsultaRips : BaseEntity
    {
        [Required]
        public string? CoRiPrestador { get; set; }
        [Required]
        public DateTime? CoRiFechaConsulta { get; set; }
        [Required]
        [MaxLength(30)]
        public string? CoRiNumAutorizacion { get; set; }
        [Required]
        [MaxLength(6)]
        public string? CoRiCodCups { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiModGrSerAtencion { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiGrupoServicios { get; set; }
        [Required]
        [MaxLength(4)]
        public short? CoRiCodigoServicios { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiFinalidadConsulta { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiCausaMotivoAtencion { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? CoRiCodigoDiagPrincipal { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? CoRiCodigoDiagRel1 { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? CoRiCodigoDiagRel2 { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? CoRiCodigoDiagRel3 { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiTipoDiagPrincipal { get; set; }
        [MaxLength(10)]
        public int? CoRiValorConsulta { get; set; }
        [Required]
        [MaxLength(2)]
        public string? CoRiTipoPagoModerador { get; set; }
        [Required]
        [MaxLength(10)]
        public int? CoRiValorPagoModerador { get; set; }
        [Required]
        public string? CoriNumFactPagoMod { get; set; }
        [Required]
        [MaxLength(7)]
        public int? CoRiConsecutivo { get; set; }


        public virtual int CoRiUsuarioSaludRipsId { get; set; }


        [Required]
        public virtual UsuarioSaludRips? CoRiUsuarioSaludRips { get; set; }

    }
}
