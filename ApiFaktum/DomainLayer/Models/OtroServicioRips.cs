using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OtroServicioRips
    {
        public int? OtRiId { get; set; }
        public string? OtRiPrestador { get; set; }
        public string? OtRiUsuarioRips { get; set; }
        public string? OtRiNumAutoriza { get; set; }
        public int? OtRiIdMiPres { get; set; }
        public DateTime? OtRiFechaServicio { get; set; }
        public string? OtRiTipoOtro { get; set; }
        public string? OtRiDetaBorrador { get; set; }
        public int? OtRiTipoIdMedico { get; set; }
        public string? OtRiNumDocMedico { get; set; }
        public string? OtRiCodCups { get; set; }
        public string? OtRiVUnitario { get; set; }
        public string? OtRiValorServicio { get; set; }
        public string? OtRiTipoPagoModerador { get; set; }
        public string? OtRiValorPagoModerador { get; set; }
        public string? OtRiNumFactPagoMod { get; set; }
    }
}
