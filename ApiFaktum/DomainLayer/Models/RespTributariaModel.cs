
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespTributariaModel : BaseEntity
    {
        [Required]
        public string? RetrCodigo { get; set; }
        [Required]
        public string? RetrNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? RetrEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? RetrClientes { get; set; }
    }
}
