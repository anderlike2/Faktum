using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ResolucionSucursalModel : BaseEntity
    {
        [Required]
        public virtual ResolucionModel? ResuResolucion { get; set; }
        [Required]
        public virtual SucursalModel? ResuSucursal { get; set; }

        //Referencias para consultas
        public virtual int ResuResolucionId { get; set; }
        public virtual int ResuSucursalId { get; set; }
    }
}
