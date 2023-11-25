using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class IumModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IumCodigo { get; set; }
        public string? IumNombre { get; set; }
        public string? IumUnidad { get; set; }
        public bool? IumEstado { get; set; }
        public DateTime? IumFechaCreacion { get; set; }
        public DateTime? IumFechaModificacion { get; set; }
    }
}
