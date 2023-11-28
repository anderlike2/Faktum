using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class LocalidadModel : BaseEntity
    {
        [Required]
        public string? LocaCodigo { get; set; }
        [Required]
        public string? LocaNombre { get; set; }
        [Required]
        public virtual DeptoModel? LocaDepto { get; set; }
        [Required]
        public virtual CiudadModel? LocaCiudad{ get; set; }
    }
}
