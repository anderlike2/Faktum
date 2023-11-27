using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class MonedaModel : BaseEntity
    {
        [Required]
        public int MoneCodigo { get; set; }
        [Required]
        public string? MoneNombre { get; set; }
    }
}
