using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class UsuarioDto
    {
        public int UsuaId { get; set; }
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }
        public bool? UsuaEstado { get; set; }
        public DateTime? UsuaFechaCreacion { get; set; }
        public DateTime? UsuaFechaModificacion { get; set; }
        public List<RolesUsuarioDto>? UsuRoles { get; set; }
    }
}
