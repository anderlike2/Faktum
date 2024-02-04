using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaizConsultaRips : BaseEntity
    {
        [Required]
        public virtual ConsultaRips? ObRaCoRiConsultaRips { get; set; }
        [Required]
        public virtual ObjetoRaiz? ObRaCoRiObjetoRaiz { get; set; }

        //Referencias consultas
        public virtual int ObRaCoRiConsultaRipsId { get; set; }
        public virtual int ObRaCoRiObjetoRaizId { get; set; }
    }
}
