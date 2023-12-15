namespace DomainLayer.Dtos
{
    public class UnidadDto : BaseDto
    {
        public string? UnidCodigoDian { get; set; }
        public string? UnidCodigo { get; set; }
        public string? UnidNombre { get; set; }

        //Referencias
        public int? UnidEmpresaId { get; set; }
    }
}
