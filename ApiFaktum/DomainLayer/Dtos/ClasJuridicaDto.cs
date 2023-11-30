namespace DomainLayer.Dtos
{
    public class ClasJuridicaDto : BaseDto
    {
        public string? JuriCodigo { get; set; }
        public string? JuriNombre { get; set; }
        public int JuriEstadoOperacion { get; set; }
    }
}
