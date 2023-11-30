namespace DomainLayer.Dtos
{
    public class CentroCostoDto : BaseDto
    {
        public string? CcosCodigo { get; set; }
        public string? CcosNombre { get; set; }

        //Referencias
        public int CcosEmpresaId { get; set; }
        public int CcosTipoDescuentoId { get; set; }
    }
}
