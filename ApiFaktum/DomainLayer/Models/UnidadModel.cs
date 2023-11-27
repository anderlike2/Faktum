using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class UnidadModel : BaseEntity
    {
        [Required]
        public string? UnidCodigoDian { get; set; }
        [Required]
        public string? UnidCodigo { get; set; }
        [Required]
        public string? UnidNombre { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? UnidEmpresa { get; set; }
        [Required]
        public virtual ICollection<ProductoModel>? UnidProductos { get; set; }
        [Required]
        public virtual ICollection<DetalleFactModel>? UnidDetFacturas { get; set; }
    }
}
