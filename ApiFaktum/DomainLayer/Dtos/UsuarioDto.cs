namespace DomainLayer.Dtos
{
    public class UsuarioDto : BaseDto
    {
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }

        //Referencias
        public List<RolDto>? UsuRoles {  get; set; }

        public int? UsuEmpresaId { get; set; }
        public int? UsuRolId { get; set; }
    }
}
