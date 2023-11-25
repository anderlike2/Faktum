using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolesUsuarioModel
    {
        [Key]
        public int RoleId { get; set; }
        public virtual UsuarioModel? RoleUsuario { get; set; }
        public virtual RolModel? RoleRol { get; set; }
        public bool? RoleEstado { get; set; }
        public DateTime? RoleFechaCreacion { get; set; }
        public DateTime? RoleFechaModificacion { get; set; }
    }
}
