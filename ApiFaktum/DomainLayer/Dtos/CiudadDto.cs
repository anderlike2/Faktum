using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class CiudadDto : BaseDto
    {
        public int CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }

        //Referencias
        public DeptoDto? CiudDepto { get; set; }
        public ICollection<ClienteDto>? CiudClientes { get; set; }
    }
}
