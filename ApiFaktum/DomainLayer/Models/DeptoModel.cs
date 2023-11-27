
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class DeptoModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptoCodigo { get; set; }
        [Required]
        public string? DeptoNombre { get; set; }
        [Required]
        public bool? DeptoEstado { get; set; }
        [Required]
        public DateTime? DeptoFechaCreacion { get; set; }
        public DateTime? DeptoFechaModificacion { get; set; }

        //Navegacion
        public virtual ICollection<CiudadModel>? Ciudades { get; set; }
    }
}
