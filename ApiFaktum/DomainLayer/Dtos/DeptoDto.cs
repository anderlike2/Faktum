namespace DomainLayer.Dtos
{
    public class DeptoDto
    {
        public int DeptoCodigo { get; set; }
        public string? DeptoNombre { get; set; }
        public bool? DeptoEstado { get; set; }
        public DateTime? DeptoFechaCreacion { get; set; }
        public DateTime? DeptoFechaModificacion { get; set; }
    }
}
