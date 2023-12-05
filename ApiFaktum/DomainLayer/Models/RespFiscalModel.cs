using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RespFiscalModel : BaseEntity
    {
        [Required]
        public string? RefiCodigo { get; set; }
        [Required]
        public string? RefiNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? RefiEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? RefiClientes { get; set; }
    }
}
