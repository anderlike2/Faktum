namespace DomainLayer.Dtos
{
    public class DeptoDto : BaseDto
    {
        public int DeptoCodigo { get; set; }
        public string? DeptoNombre { get; set; }
        public List<CiudadDto>? DeptoCiudades { get; set; }
    }
}
