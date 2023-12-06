namespace DomainLayer.Dtos
{
    public class FormatoImpresionDto : BaseDto
    {
        public string? FormCodigo { get; set; }
        public string? FormNombre { get; set; }

        //Referencias
        public int? FormEmpresaId { get; set; }
    }
}
