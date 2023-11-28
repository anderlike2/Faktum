using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoClienteModel : BaseEntity
    {
        [Required]
        public string? TiclCodigo { get; set; }
        [Required]
        public string? TiclNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? TiclEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? TiclClientes { get; set; }
    }
}
