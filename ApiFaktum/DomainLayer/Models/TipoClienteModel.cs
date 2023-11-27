using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class TipoClienteModel : BaseEntity
    {
        [Required]
        public int TiclCodigo { get; set; }
        [Required]
        public string? TiclNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? TiclEmpresas { get; set; }
    }
}
