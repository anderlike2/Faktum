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
        [Required]
        public virtual ICollection<SucursalModel>? CcosSucursales { get; set; }
        [Required]
        public virtual TipoDescuentoModel? CcosTipoDescuento { get; set; }

        //Referencias para consultas
        public virtual int CcosEmpresaId {  get; set; }
        public virtual int CcosTipoDescuentoId { get; set; }
    }
}
