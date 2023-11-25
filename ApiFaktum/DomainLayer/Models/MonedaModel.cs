using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class MonedaModel
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MoneCodigo { get; set; }
        [Required]
        public string? MoneNombre { get; set; }
        [Required]
        public bool? MoneEstado { get; set; }
        [Required]
        public DateTime? MoneFechaCreacion { get; set; }
        public DateTime? MoneFechaModificacion { get; set; }
    }
}
