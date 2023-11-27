using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CiudadModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CiudCodigo { get; set; }
        [Required]
        public string? CiudNombre { get; set; }
        [Required]
        public int CiudDepto { get; set; }
        [Required]
        public bool? CiudEstado { get; set; }
        [Required]
        public DateTime? CiudFechaCreacion { get; set; }
        public DateTime? CiudFechaModificacion { get; set; }
        
        //Navegacion
        public virtual DeptoModel? Depto { get; set; }
    }
}
