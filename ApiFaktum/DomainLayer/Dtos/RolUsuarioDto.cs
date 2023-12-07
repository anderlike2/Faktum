using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class RolUsuarioDto : BaseDto
    {
        //Referencias
        public UsuarioModel? RousUsuario { get; set; }
        public RolModel? RousRol { get; set; }

        //Para consultas
        public int? RousUsuarioId { get; set; }
        public int? RousRolId { get; set; }
    }
}
