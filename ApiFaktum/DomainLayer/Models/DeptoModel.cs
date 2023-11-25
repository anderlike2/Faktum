
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class DeptoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptoCodigo { get; set; }
        public string? DeptoNombre { get; set; }
        public bool? DeptoEstado { get; set; }
        public DateTime? DeptoFechaCreacion { get; set; }
        public DateTime? DeptoFechaModificacion { get; set; }
    }
}
