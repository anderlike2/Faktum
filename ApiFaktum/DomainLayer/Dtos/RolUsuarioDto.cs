namespace DomainLayer.Dtos
{
    public class RolUsuarioDto : BaseDto
    {
        //Referencias
        public UsuarioDto? RousUsuario { get; set; }
        public RolDto? RousRol { get; set; }

        //Para consultas
        public int? RousUsuarioId { get; set; }
        public int? RousRolId { get; set; }
    }
}
