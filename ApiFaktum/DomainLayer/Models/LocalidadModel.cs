using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class LocalidadModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocaCodigo { get; set; }
        public string? LocaNombre { get; set; }
        public virtual DeptoModel? LocaDepto { get; set; }
        public virtual CiudadModel? LocaCiudad{ get; set; }
        public bool? LocaEstado { get; set; }
        public DateTime? LocaFechaCreacion { get; set; }
        public DateTime? LocaFechaModificacion { get; set; }
    }
}
