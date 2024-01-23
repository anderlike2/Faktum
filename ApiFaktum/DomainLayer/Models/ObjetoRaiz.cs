using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaiz
    {
        public int? ObRaId { get; set; }
        public string? ObRaEmpresa { get; set; }
        public string? ObRaNit { get; set; }
        public string? ObRaNumFactura { get; set; }
        public string? ObRaBorrador { get; set; }
        public string? ObRaNumBorrador { get; set; }
        public string? ObRaTipoNotaRips { get; set; }
        public string? ObRaNumNc {  get; set; }
        public string? ObRaNumNd { get; set; }
        public string? ObRaOrigenRips { get; set; }
        public string? ObRaJsOn { get; set; }
        public string? ObRaEstadoRips { get; set; }
        public string? ObRaTerminado { get; set; }
        public string? ObRaGenerado { get; set; }
        public string? ObRaOperador { get; set; }

    }
}
