namespace DomainLayer.Dtos
{
    public class ClasJuridicaDto
    {
        public int JuriCodigo { get; set; }
        public string? JuriNombre { get; set; }
        public bool? JuriEstadoOperacion { get; set; }
        public bool? JuriEstado { get; set; }
        public DateTime? JuriFechaCreacion { get; set; }
        public DateTime? JuriFechaModificacion { get; set; }
    }
}
