using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Dtos
{
    public class VendedorDto : BaseDto
    {
        public string? VendCodigo { get; set; }
        public string? VendNombre { get; set; }
        public string? VendTipoDoc { get; set; }

        //Referencias
        public EmpresaDto? VendEmpresa { get; set; }
    }
}
