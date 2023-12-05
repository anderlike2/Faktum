using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class OtroProductoModel : BaseEntity
    {
        [Required]
        public string? OtprCodigo { get; set; }
        [Required]
        public string? OtprNombre { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? OtprEmpresa { get; set; }        
        [Required]
        public virtual ICollection<ProductoModel>? OtprProductos { get; set; }

        //Referencias para consultas FK
        public virtual int OtprEmpresaId { get; set; }
    }
}
