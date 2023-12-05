namespace DomainLayer.Dtos
{
    public class OtroProductoDto : BaseDto
    {
        public string? OtprCodigo { get; set; }
        public string? OtprNombre { get; set; }

        //Referencias para consultas FK
        public virtual int OtprEmpresaId { get; set; }
    }
}
