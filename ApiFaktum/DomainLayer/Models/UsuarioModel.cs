using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class UsuarioModel
    {
        [Key]
        public int UsuaId { get; set; }
        public string? UsuaUsuario { get; set; }
        public string? UsuaPassword { get; set; }
        public int? UsuaIntentos { get; set; }
        public bool? UsuaEstado { get; set; }
        public DateTime? UsuaFechaCreacion { get; set; }
        public DateTime? UsuaFechaModificacion { get; set; }
        public virtual ICollection<RolesUsuarioModel>? UsuRoles { get; set; }
    }
}
