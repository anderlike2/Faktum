﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RegimenModel : BaseEntity
    {
        [Required]
        public int RegiCodigo { get; set; }
        [Required]
        public string? RegiNombre { get; set; }
        [Required]
        public int RegiEstadoOperacion { get; set; }
    }
}
