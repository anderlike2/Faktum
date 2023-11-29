﻿namespace DomainLayer.Dtos
{
    public class UsuarioDto : BaseDto
    {
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }

        //Referencias
        public EmpresaDto? UsuEmpresa { get; set; }
        public List<RolUsuarioDto>? UsuRolesUsuario { get; set; }
    }
}
