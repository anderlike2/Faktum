using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class RegimenModel : BaseEntity
    {
        [Required]
        public int RegiCodigo { get; set; }
        [Required]
        public string? RegiNombre { get; set; }
        [Required]
        public int RegiEstadoOperacion { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? RegiEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? RegiClientes { get; set; }
    }
}
