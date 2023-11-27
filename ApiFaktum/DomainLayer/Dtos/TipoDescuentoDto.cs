using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class TipoDescuentoDto : BaseDto
    {
        public int TideCodigo { get; set; }
        public string? TideNombre { get; set; }

        //Referencias
        public List<FacturaDto>? TideFacturas { get; set; }
    }
}
