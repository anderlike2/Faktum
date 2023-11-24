namespace DomainLayer.Models
{
    public class RolesUsuarioModel
    {
        public int RoleId { get; set; }
        public bool RoleEstado { get; set; }
        public virtual UsuarioModel? RoleUsuario { get; set; }
        public virtual RolModel? RoleRol { get; set; }
    }
}
