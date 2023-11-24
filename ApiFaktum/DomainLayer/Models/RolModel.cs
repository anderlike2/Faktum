namespace DomainLayer.Models
{
    public class RolModel
    {
        public int RolId { get; set; }
        public string? RolCodigo { get; set; }
        public string? RolDescripcion { get; set; }
        public bool RolEstado { get; set; }
        public virtual ICollection<RolesUsuarioModel>? RolUsuarios { get; set; }
    }
}
