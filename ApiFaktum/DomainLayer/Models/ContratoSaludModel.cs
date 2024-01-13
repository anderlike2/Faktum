using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ContratoSaludModel : BaseEntity
    {
        [Required]
        public string? CosaContrato { get; set; }
        [Required]
        public string? CosaPoliza { get; set; }

        //Referencias
        [Required]
        public virtual ClienteModel? CosaClie { get; set; }
        [Required]
        public virtual CoberturaModel? CosaCobe { get; set; }
        [Required]
        public virtual EmpresaModel? CosaEmpresa { get; set; }
        [Required]
        public virtual ModalidadPagoModel? CosaMopa { get; set; }

        //Para creacion de datos mediante FK
        public virtual int CosaClieId { get; set; }
        public virtual int CosaCobeId { get; set; }
        public virtual int CosaEmpresaId { get; set; }
        public virtual int CosaMopaId { get; set; }
    }
}
