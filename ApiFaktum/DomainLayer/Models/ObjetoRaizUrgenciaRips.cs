using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaizUrgenciaRips : BaseEntity
    {
        [Required]
        public virtual UrgenciaRips? ObRaUrRiUrgenciaRips { get; set; }
        [Required]
        public virtual ObjetoRaiz? ObRaUrRiObjetoRaiz { get; set; }

        public virtual int ObRaUrRiUrgenciaRipsId { get; set; }
        public virtual int ObRaUrRiObjetoRaizId { get; set; }
    }
}
