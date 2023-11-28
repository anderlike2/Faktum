using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class FormatoImpresionDto : BaseDto
    {
        public string? FormCodigo { get; set; }
        public string? FormNombre { get; set; }

        //Referencias
        public EmpresaDto? FormEmpresa { get; set; }
        public List<FacturaDto>? FormFacturas { get; set; }
        public List<SucursalDto>? FormSucursales { get; set; }
    }
}
