using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ListaPrecioModel : BaseEntity
    {
        [Required]
        public string? LiprDescripcion { get; set; }
        [Required]
        public int LiprEstadoOperacion { get; set; }
        [Required]
        public string? LiprNombre { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? LiprEmpresa { get; set; }

        //Referencias para consultas
        public virtual int LiprEmpresaId { get; set; }
    }
}
