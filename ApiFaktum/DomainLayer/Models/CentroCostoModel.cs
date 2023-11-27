using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class CentroCostoModel : BaseEntity
    {
        [Required]
        public string? CcosCodigo { get; set; }
        [Required]
        public string? CcosNombre { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? CcosEmpresa { get; set; }
        [Required]
        public virtual ICollection<ProductoModel>? CcosProductos { get; set; }
    }
}
