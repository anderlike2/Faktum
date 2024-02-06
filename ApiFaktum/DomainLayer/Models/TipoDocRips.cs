using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class TipoDocRips : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string? TiDrCodigo { get; set; }
        [Required]
        public string? TiDrNombre { get; set; }

    }
}
