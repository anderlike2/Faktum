using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class RolModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        public string? RolCodigo { get; set; }
        public string? RolDescripcion { get; set; }
        public bool? RolEstado { get; set; }
        public DateTime? RolFechaCreacion { get; set; }
        public DateTime? RolFechaModificacion { get; set; }
        public virtual ICollection<RolesUsuarioModel>? RolUsuarios { get; set; }
    }
}
