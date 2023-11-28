namespace DomainLayer.Dtos
{
    public class PaisDto : BaseDto
    {
        public string? PaisCodigo { get; set; }
        public string? PaisNombre { get; set; }

        //Referencias
        public List<ClienteDto>? PaisClientes { get; set; }
    }
}
