using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class UsuarioModel : BaseEntity
    {
        [Required]
        public string? UsuaUsuario { get; set; }
        [Required]
        public string? UsuaPassword { get; set; }
        [Required]
        public int? UsuaIntentos { get; set; }
        [Required]
        public virtual EmpresaModel? UsuEmpresa { get; set; }
    }
}
