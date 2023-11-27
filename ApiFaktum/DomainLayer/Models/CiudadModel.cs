using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CiudadModel : BaseEntity
    {
        [Required]
        public int CiudCodigo { get; set; }
        [Required]
        public string? CiudNombre { get; set; }
        [Required]
        public virtual DeptoModel? CiudDepto { get; set; }
    }
}
