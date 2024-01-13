namespace DomainLayer.Dtos
{
    public class CiudadDto : BaseDto
    {
        public string? CiudCodigo { get; set; }
        public string? CiudNombre { get; set; }

        //Referencias
        public int? CiudDeptoId { get; set; }
        public int? CiudEmpresaId { get; set; }
    }
}
