using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class RolUsuarioModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RousCodigo { get; set; }
        [Required]
        public virtual UsuarioModel? RousUsuario { get; set; }
        [Required]
        public virtual RolModel? RousRol { get; set; }
        [Required]
        public bool? RousEstado { get; set; }
        [Required]
        public DateTime? RousFechaCreacion { get; set; }
        public DateTime? RousFechaModificacion { get; set; }
    }
}
