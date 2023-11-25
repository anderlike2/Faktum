
namespace DomainLayer.Dtos
{
    public class FactSaludTipoDto
    {
        public int FasaCodigo { get; set; }
        public string? FasaNombre { get; set; }
        public bool? FasaEstado { get; set; }
        public DateTime? FasaFechaCreacion { get; set; }
        public DateTime? FasaFechaModificacion { get; set; }
    }
}
