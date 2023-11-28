namespace DomainLayer.Dtos
{
    public class RolDto : BaseDto
    {
        public string? RolCodigo { get; set; }
        public string? RolDescripcion { get; set; }

        //Referencias
        public List<RolUsuarioDto>? RolRolesUsuario { get; set; }
    }
}
