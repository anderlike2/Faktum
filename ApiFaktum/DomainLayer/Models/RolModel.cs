using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolModel
    {
        [Key]
        public int RolId { get; set; }
        public string? RolCodigo { get; set; }
        public string? RolDescripcion { get; set; }
        public bool? RolEstado { get; set; }
        public DateTime? RolFechaCreacion { get; set; }
        public DateTime? RolFechaModificacion { get; set; }
        public virtual ICollection<RolesUsuarioModel>? RolUsuarios { get; set; }
    }
}
