using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class MedicamentosRips : BaseEntity
    {
        public string? MeRiPrestador { get; set; }
        public string? MeRiUsuariosRips { get; set; }
        public string? MeRiNumAutoriza { get; set; }
        public string? MeRiMiPresid { get; set; }
        public DateTime? MeRiDisp { get; set; }
        public string? MeRiCodigoDiagPrincipal { get; set; }
        public string? MeRiCodigoDiagRel { get; set; }
        public string? MeRiTipoMed { get; set; }
        public string? MeRiDetaBorrador { get; set; }
        public string? MeRiNombreMedicamento { get; set; }
        public string? MeRiConcentracion { get; set; }
        public string? MeRiUnidad { get; set; }
        public string? MeRiFormaFarmaceutica { get; set; }
        public string? MeRiUnidadMinimaDisp { get; set; }
        public string? MeRiCantidadDisp { get; set; }
        public string? MeRiNumDias { get; set; }
        public int? MeRiTipoIdMedico { get; set; }
        public string? MeRiNumDocMedico { get; set; }
        public string? MeRiValUnitario { get; set; }
        public string? MeRiValorServicio { get; set; }
        public string? MeRiTipoPagoModerador { get; set; }
        public string? MeRiValorPagoModerador { get; set; }
        public string? MeRiNumFactPagoMod { get; set; }

    }
}
