using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CiudadModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }
        public virtual DeptoModel? CiudDepto { get; set; }
        public bool? CiudEstado { get; set; }
        public DateTime? CiudFechaCreacion { get; set; }
        public DateTime? CiudFechaModificacion { get; set; }
    }
}
