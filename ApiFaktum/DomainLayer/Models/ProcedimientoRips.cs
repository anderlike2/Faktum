using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProcedimientoRips : BaseEntity
    {
        [Required]
        [MaxLength(12)]
        public string? PrRiPrestador { get; set; }
        [Required]
        public DateTime? PrRiFechaConsulta { get; set; }
        [Required]
        [MaxLength(15)]
        public int? PrRiIdMPres { get; set; }
        [Required]
        [MaxLength(30)]
        public string? PrRiNumAutorizacion { get; set; }
        [Required]
        [MaxLength(6)]
        public string? PrRiCodCups { get; set; }
        [Required]
        [MaxLength(2)]
        public string? PrRiViaIngresoUsuario { get; set; }
        [Required]
        [MaxLength(2)]
        public string? PrRiModGrServAtencion { get; set; }
        [Required]
        [MaxLength(2)]
        public string? PrRiGrupoServicios { get; set; }
        [Required]
        [MaxLength(4)]
        public short? PrRiCodigoServicios { get; set; }
        [Required]
        [MaxLength(2)]
        public string? PrRiFinalidadConsulta { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? PrRiCodigoDiagPrincipal { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? PrRiCodigoDiagRel { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string? PrRiComplicacion { get; set; }
        [Required]
        [MaxLength(15)]
        public int? PrRiValorProcedimiento { get; set; }
        [Required]
        [MaxLength(2)]
        public string? PrRiTipoPagoModerador { get; set; }
        [Required]
        [MaxLength(10)]
        public int? PrRiValorPagoModerador { get; set; }
        [Required]  
        public string? PrRiNumFactPagoMod { get; set; }
        [Required]
        public int? PrRiConsecutivo { get; set; }


        public virtual int PrRiUsuarioSaludRipsId { get; set; }

        [Required]
        public virtual UsuarioSaludRips? PrRiUsuarioSaludRips { get; set; }

    }
}
