﻿using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class UsuarioModel : BaseEntity
    {
        [Required]
        public int UsuaCodigo { get; set; }
        [Required]
        public string? UsuaUsuario { get; set; }
        [Required]
        public string? UsuaPassword { get; set; }
        [Required]
        public int? UsuaIntentos { get; set; }
    }
}
