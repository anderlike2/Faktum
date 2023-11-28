using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class ClaseFacturaDto : BaseDto
    {
        public int ClfaCodigo { get; set; }
        public string? ClfaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? ClfaFacturas { get; set; }
    }
}
