namespace DomainLayer.Dtos
{
    public class NumeracionResolucionDto
    {
        public int NureCodigo { get; set; }
        public int NureNumeracionActual { get; set; }
        public bool? NureEstado { get; set; }
        public DateTime? NureFechaCreacion { get; set; }
        public DateTime? NureFechaModificacion { get; set; }
    }
}
