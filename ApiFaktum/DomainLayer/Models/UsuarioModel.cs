using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class UsuarioModel : BaseEntity
    {
        [Required]
        public string? UsuaUsuario { get; set; }
        [Required]
        public string? UsuaPassword { get; set; }
        [Required]
        public int? UsuaIntentos { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresasUsuarioModel>? UsuEmpresasUsuario { get; set; }
        public virtual ICollection<RolUsuarioModel>? UsuRolesUsuario { get; set; }
    }
}
