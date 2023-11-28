namespace DomainLayer.Dtos
{
    public class LocalidadDto : BaseDto
    {
        public int LocaCodigo { get; set; }
        public string? LocaNombre { get; set; }

        //Referencias
        public DeptoDto? LocaDepto { get; set; }
        public CiudadDto? LocaCiudad { get; set; }
    }
}
