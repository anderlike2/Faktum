using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RolUsuarioModel : BaseEntity
    {
        //Navegacion
        public virtual UsuarioModel? RousUsuario { get; set; }
        public virtual RolModel? RousRol { get; set; }
    }
}
