namespace DomainLayer.Dtos
{
    public class UsuarioDto
    {
        public int UsuaCodigo { get; set; }
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }
        public bool? UsuaEstado { get; set; }
        public DateTime? UsuaFechaCreacion { get; set; }
        public DateTime? UsuaFechaModificacion { get; set; }
        public List<RolUsuarioDto>? UsuRoles { get; set; }
    }
}
