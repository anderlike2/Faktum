﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ImpuestoModel : BaseEntity
    {
        [Required]
        public string? ImpuCodigo { get; set; }
        [Required]
        public string? ImpuNombre { get; set; }
        [Required]
        public int ImpuEstadoOperacion { get; set; }
        [Required]
        public string? ImpuOperacion { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ImpuPorcentaje { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? ImpuProductos { get; set; }
        [Required]
        public virtual ICollection<DetalleFactModel>? ImpuDetFacturas { get; set; }
    }
}
