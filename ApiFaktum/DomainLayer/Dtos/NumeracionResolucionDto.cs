namespace DomainLayer.Dtos
{
    public class NumeracionResolucionDto : BaseDto
    {
        public string? NureCodigo { get; set; }
        public int NureNumeracionActual { get; set; }

        //Referencias
        public List<ResolucionDto>? NureResoluciones { get; set; }
    }
}
