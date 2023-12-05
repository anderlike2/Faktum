namespace DomainLayer.Dtos
{
    public class CiudadDto : BaseDto
    {
        public string? CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }

        //Referencias
        public DeptoDto? CiudDepto { get; set; }
        public ICollection<ClienteDto>? CiudClientes { get; set; }
    }
}
