using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class UsuarioModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuaCodigo { get; set; }
        [Required]
        public string? UsuaUsuario { get; set; }
        [Required]
        public string? UsuaPassword { get; set; }
        [Required]
        public int? UsuaIntentos { get; set; }
        [Required]
        public bool? UsuaEstado { get; set; }
        [Required]
        public DateTime? UsuaFechaCreacion { get; set; }
        public DateTime? UsuaFechaModificacion { get; set; }
        
        //Navegacion
        public virtual ICollection<RolUsuarioModel>? Roles { get; set; }
    }
}
