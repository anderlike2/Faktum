
using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class CupDto : BaseDto
    {
        public int CupsCodigo { get; set; }
        public string? CupsNombre { get; set; }

        //Referencias
        public List<ProductoDto>? CupsProductos { get; set; }
    }
}
