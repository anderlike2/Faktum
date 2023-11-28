using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public int Estado { get; set; }
        [Required]
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
