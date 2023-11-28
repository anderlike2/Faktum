using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ContratoSaludModel : BaseEntity
    {
        [Required]
        public string? CosaContrato { get; set; }
        [Required]
        public string? CosaNitCliente { get; set; }
        [Required]
        public string? CosaPoliza { get; set; }

        //Referencias
        [Required]
        public virtual ClienteModel? CosaClieId { get; set; }
        [Required]
        public virtual CoberturaModel? CosaCobe { get; set; }
        [Required]
        public virtual EmpresaModel? CosaEmpresa { get; set; }
        [Required]
        public virtual ModalidadPagoModel? CosaMopa { get; set; }
    }
}
