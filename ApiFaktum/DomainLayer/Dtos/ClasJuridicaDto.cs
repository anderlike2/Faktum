namespace DomainLayer.Dtos
{
    public class ClasJuridicaDto : BaseDto
    {
        public int JuriCodigo { get; set; }
        public string? JuriNombre { get; set; }
        public int JuriEstadoOperacion { get; set; }

        //Referencias
        public List<EmpresaDto>? JuriEmpresas { get; set; }
    }
}
