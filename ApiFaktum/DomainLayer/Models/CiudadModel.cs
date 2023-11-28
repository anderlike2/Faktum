using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CiudadModel : BaseEntity
    {
        [Required]
        public int CiudCodigo { get; set; }
        [Required]
        public string? CiudNombre { get; set; }

        //Referencias
        [Required]
        public virtual DeptoModel? CiudDepto { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? CiudClientes { get; set; }
    }
}
