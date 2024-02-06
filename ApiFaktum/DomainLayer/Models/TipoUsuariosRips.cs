using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class TipoUsuariosRips : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string? TiRiCodigo { get; set; }
        [Required]
        public string?  TiRiNombre { get; set; }
    }
}
