namespace DomainLayer.Models
{
    public class UsuarioModel
    {
        public int UsuaId { get; set; }
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int UsuaIntentos { get; set; }
        public bool UsuaEstado { get; set; }
        public virtual ICollection<RolesUsuarioModel>? UsuRoles { get; set; }
    }
}
