using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ObjetoRaizUsuarioRips : BaseEntity
    {
        [Required]
        public virtual UsuarioSaludRips? ObRaUsUaUsuario { get; set; }
        [Required]
        public virtual ObjetoRaiz? ObRaUsUaObjetoRaiz { get; set; }

        //Referencias consultas
        public virtual int ObRaUsUaUsuarioId { get; set; }
        public virtual int ObRaUsUaObjetoRaizId { get; set; }
    }
}
