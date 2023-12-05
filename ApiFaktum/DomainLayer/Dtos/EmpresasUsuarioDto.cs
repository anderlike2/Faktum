namespace DomainLayer.Dtos
{
    public class EmpresasUsuarioDto : BaseDto
    {
        public UsuarioDto? EmusUsuario { get; set; }
        public EmpresaDto? EmusEmpresa { get; set; }

        //Referencias
        public int EmusUsuarioId { get; set; }
        public int EmusEmpresaId { get; set; }
    }
}
