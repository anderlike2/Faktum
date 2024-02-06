using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class TipoNotaRips : BaseEntity  
    {
        [Required]
        [MaxLength(2)]
        public string? TiNrCodigo { get; set; }
        [Required]
        public string? TiNrNombre { get; set; }
    }
}
