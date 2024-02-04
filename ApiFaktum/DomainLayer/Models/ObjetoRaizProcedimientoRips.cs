using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaizProcedimientoRips : BaseEntity
    {
        [Required]
        public virtual ProcedimientoRips? ObRaPrRiProcedimientoRips { get; set; }
        [Required]
        public virtual ObjetoRaiz? ObRaPrRiObjetoRaiz { get; set; }

        public virtual int ObRaPrRiProcedimientoRipsId { get; set; }
        public virtual int ObRaPrRiObjetoRaizId { get; set; }
    }
}
