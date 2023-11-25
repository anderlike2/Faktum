using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class LocalidadModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocaCodigo { get; set; }
        [Required]
        public string? LocaNombre { get; set; }
        [Required]
        public virtual DeptoModel? LocaDepto { get; set; }
        [Required]
        public virtual CiudadModel? LocaCiudad{ get; set; }
        [Required]
        public bool? LocaEstado { get; set; }
        [Required]
        public DateTime? LocaFechaCreacion { get; set; }
        public DateTime? LocaFechaModificacion { get; set; }
    }
}
