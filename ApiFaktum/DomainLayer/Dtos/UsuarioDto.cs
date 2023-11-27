namespace DomainLayer.Dtos
{
    public class UsuarioDto : BaseDto
    {
        public int UsuaCodigo { get; set; }
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }
    }
}
