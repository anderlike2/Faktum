
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespTributariaModel : BaseEntity
    {
        [Required]
        public int RetrCodigo { get; set; }
        [Required]
        public string? RetrNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? RetrEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? RetrClientes { get; set; }
    }
}
