﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ResolucionModel : BaseEntity
    {
        [Required]
        public string? ResoAnio { get; set; }
        [Required]
        public long ResoConsActual { get; set; }
        [Required]
        public long ResoConsFinal { get; set; }
        [Required]
        public long ResoConsInicial { get; set; }
        [Required]
        public int ResoEstadoOperacion { get; set; }
        [Required]
        public DateTime ResoFechaExpide { get; set; }
        [Required]
        public string? ResoPrefijo { get; set; }
        [Required]
        public DateTime ResoVigencia { get; set; }
        [Required]
        public string? ResoCodigo { get; set; }
        [Required]
        public int ResoNumeracionActual { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? ResoEmpresa { get; set; }
        [Required]
        public virtual TipoDocElectrModel? ResoTipoDoc { get; set; }
        [Required]
        public virtual ICollection<ResolucionSucursalModel>? ResoResoluciones { get; set; }

        //Referencias para consultas
        public virtual int ResoEmpresaId { get; set; }
        public virtual int ResoTipoDocId { get; set; }
    }
}
