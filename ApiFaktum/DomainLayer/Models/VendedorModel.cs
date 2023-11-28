using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class VendedorModel : BaseEntity
    {
        [Required]
        public string? VendCodigo { get; set; }
        [Required]
        public string? VendNombre { get; set; }
        [Required]
        public string? VendTipoDoc { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? VendEmpresa { get; set; }
    }
}
