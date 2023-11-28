using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class TipoIdDto : BaseDto
    {
        public int TiidCodigo { get; set; }
        public string? TiidNombre { get; set; }

        //Referencias
        public List<EmpresaDto>? TiidEmpresas { get; set; }
        public List<ClienteDto>? TiidClientes { get; set; }
    }
}
