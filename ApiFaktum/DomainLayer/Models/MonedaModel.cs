using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class MonedaModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MoneCodigo { get; set; }
        public string? MoneNombre { get; set; }
        public bool? MoneEstado { get; set; }
        public DateTime? MoneFechaCreacion { get; set; }
        public DateTime? MoneFechaModificacion { get; set; }
    }
}
