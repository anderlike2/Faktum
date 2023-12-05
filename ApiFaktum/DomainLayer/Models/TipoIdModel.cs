using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoIdModel : BaseEntity
    {
        [Required]
        public string? TiidCodigo { get; set; }
        [Required]
        public string? TiidNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? TiidEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? TiidClientes { get; set; }
    }
}
