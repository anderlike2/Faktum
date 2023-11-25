namespace DomainLayer.Dtos
{
    public class RolesUsuarioDto
    {
        public int RoleId { get; set; }
        public bool? RoleEstado { get; set; }
        public DateTime? RoleFechaCreacion { get; set; }
        public DateTime? RoleFechaModificacion { get; set; }
    }
}
