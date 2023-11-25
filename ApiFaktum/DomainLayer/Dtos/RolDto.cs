﻿namespace DomainLayer.Dtos
{
    public class RolDto
    {
        public int RolCodigo { get; set; }
        public string? RolDescripcion { get; set; }
        public bool? RolEstado { get; set; }
        public DateTime? RolFechaCreacion { get; set; }
        public DateTime? RolFechaModificacion { get; set; }
        public List<RolUsuarioDto>? RolUsuario { get; set; }
    }
}
