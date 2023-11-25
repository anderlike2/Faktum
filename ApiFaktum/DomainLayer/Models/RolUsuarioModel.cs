using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class RolUsuarioModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RousCodigo { get; set; }
        public virtual UsuarioModel? RousUsuario { get; set; }
        public virtual RolModel? RousRol { get; set; }
        public bool? RousEstado { get; set; }
        public DateTime? RousFechaCreacion { get; set; }
        public DateTime? RousFechaModificacion { get; set; }
    }
}
