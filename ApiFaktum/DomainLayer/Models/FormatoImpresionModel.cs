using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class FormatoImpresionModel : BaseEntity
    {
        [Required]
        public string? FormCodigo { get; set; }
        [Required]
        public string? FormNombre { get; set; }

        //Referencias
        [Required]
        public virtual EmpresaModel? FormEmpresa { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? FormFacturas { get; set; }
        [Required]
        public virtual ICollection<SucursalModel>? FormSucursales { get; set; }

        //Referencias para consultas
        public virtual int? FormEmpresaId { get; set; }
    }
}
