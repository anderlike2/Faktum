
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class DeptoModel : BaseEntity
    {
        [Required]
        public string? DeptoCodigo { get; set; }
        [Required]
        public string? DeptoNombre { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<CiudadModel>? DeptoCiudades { get; set; }
        [Required]
        public virtual ICollection<ClienteModel>? DeptoClientes { get; set; }
        [Required]
        public virtual ICollection<EmpresaModel>? DeptoEmpresas { get; set; }
    }
}
