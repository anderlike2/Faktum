namespace DomainLayer.Dtos
{
    public class UsuarioDto : BaseDto
    {
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }
    }
}
