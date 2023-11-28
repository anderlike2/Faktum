using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class RolUsuarioDto : BaseDto
    {
        public UsuarioModel? RousUsuario { get; set; }
        public RolModel? RousRol { get; set; }
    }
}
