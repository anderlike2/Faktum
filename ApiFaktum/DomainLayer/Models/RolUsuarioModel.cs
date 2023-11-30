using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolUsuarioModel : BaseEntity
    {
        [Required]
        public virtual UsuarioModel? RousUsuario { get; set; }
        [Required]
        public virtual RolModel? RousRol { get; set; }

        //Referencias para consultas
        public virtual int RousUsuarioId { get; set; }
        public virtual int RousRolId { get; set; }
    }
}
