using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class RolesUsuarioModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public virtual UsuarioModel? RoleUsuario { get; set; }
        public virtual RolModel? RoleRol { get; set; }
        public bool? RoleEstado { get; set; }
        public DateTime? RoleFechaCreacion { get; set; }
        public DateTime? RoleFechaModificacion { get; set; }
    }
}
