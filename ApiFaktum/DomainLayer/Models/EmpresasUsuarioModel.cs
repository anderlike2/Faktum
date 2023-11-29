using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class EmpresasUsuarioModel : BaseEntity
    {
        [Required]
        public virtual UsuarioModel? EmusUsuario { get; set; }
        [Required]
        public virtual EmpresaModel? EmusEmpresa { get; set; }
    }
}
