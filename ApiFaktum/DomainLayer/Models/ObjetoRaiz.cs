using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaiz : BaseEntity
    {
        [Required]
        [MaxLength(9)]
        public string? ObRaNit { get; set; }
        [Required]
        [MaxLength(20)]
        public string? ObRaNumNota {  get; set; }
        public string? ObRaJsOn { get; set; }
        [Required]
        public bool ObRaTerminado { get; set; }
        [Required]
        public bool ObRaGenerado { get; set; }
        [Required]
        public string? ObRaOperador { get; set; }
        [Required]
        public virtual int ObRaEmpresaId { get; set; }
        [Required]
        public virtual int ObRaFacturaId { get; set; }
        [Required]
        public virtual int ObRaTipoNotaRipsId { get; set; }
        [Required]
        public virtual int ObRaOrigenRipsId { get; set; }
        [Required]
        public virtual int? ObRaEstadoRipsId { get; set; }


        [Required]
        public virtual EmpresaModel? ObRaEmpresa { get; set; }
        [Required]
        public virtual FacturaModel? ObRaFactura { get; set; }
        [Required]
        public virtual TipoNotaRips? ObRaTipoNotaRips { get; set; }
        [Required]
        public virtual OrigenRips? ObRaOrigenRips { get; set; }
        [Required]
        public virtual EstadoRips? ObRaEstadoRips { get; set; }

    }
}
