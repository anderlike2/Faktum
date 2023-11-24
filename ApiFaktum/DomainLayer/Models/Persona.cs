﻿namespace DomainLayer.Models
{
    public class Persona : BaseEntity
    {
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
