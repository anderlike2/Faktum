namespace DomainLayer.Dtos
{
    public class PaisDto : BaseDto
    {
        public int PaisCodigo { get; set; }
        public string? PaisNombre { get; set; }

        //Referencias
        public List<ClienteDto>? PaisClientes { get; set; }
    }
}
