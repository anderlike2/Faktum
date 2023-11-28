
using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class FactSaludTipoDto : BaseDto
    {
        public int FasaCodigo { get; set; }
        public string? FasaNombre { get; set; }

        //Referencias
        public List<FacturaDto>? FasaFacturas { get; set; }
    }
}
