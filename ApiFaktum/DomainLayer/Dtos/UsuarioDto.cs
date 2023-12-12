namespace DomainLayer.Dtos
{
    public class UsuarioDto : BaseDto
    {
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public string? UsuaPasswordConfirm { get; set; }
        public int? UsuaIntentos { get; set; }

        //Referencias
        public List<RolDto>? UsuaRoles {  get; set; }

        public int? UsuaEmpresaId { get; set; }
        public int? UsuaRolId { get; set; }
    }
}
