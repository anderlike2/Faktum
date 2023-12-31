﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CoberturaModel : BaseEntity
    {
        [Required]
        public string? CobeCodigo { get; set; }
        [Required]
        public string? CobeNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? CobeFacturas { get; set; }
        [Required]
        public virtual ICollection<ContratoSaludModel>? CobeContratosSalud { get; set; }
    }
}
