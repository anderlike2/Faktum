namespace DomainLayer.Dtos
{
    public class CiudadDto : BaseDto
    {
        public int CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }
        public virtual DeptoDto? CiudDepto { get; set; }
    }
}
