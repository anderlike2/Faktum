﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoArchivoRipsModel : BaseEntity
    {
        [Required]
        public string? ArriCodigo { get; set; }
        [Required]
        public string? ArriNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ProductoModel>? ArriProductos { get; set; }
    }
}
