using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class RolModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolCodigo { get; set; }
        [Required]
        public string? RolDescripcion { get; set; }
        [Required]
        public bool? RolEstado { get; set; }
        [Required]
        public DateTime? RolFechaCreacion { get; set; }
        public DateTime? RolFechaModificacion { get; set; }
        

        //Navegacion
        public virtual ICollection<RolUsuarioModel>? Roles { get; set; }
    }
}
