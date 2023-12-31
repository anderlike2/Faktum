﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class EstadoDianFacturaModel : BaseEntity
    {
        [Required]
        public string? EsfaCodigo { get; set; }
        [Required]
        public string? EsfaNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<FacturaModel>? EsfaFacturas { get; set; }
    }
}
