using DomainLayer.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Dtos
{
    public class ClienteDto : BaseDto
    {
        public string? ClieApellidos { get; set; }
        public string? ClieCelular { get; set; }
        public string? ClieCiuu { get; set; }
        public string? ClieCobertura { get; set; }
        public string? ClieContacto { get; set; }
        public string? ClieCorreo { get; set; }
        public string? ClieCorreoFact { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ClieDescGlobal { get; set; }
        public int ClieDiasPago { get; set; }
        public string? ClieDireccion { get; set; }
        public long ClieDv { get; set; }
        public int ClieEstadoOperacion { get; set; }
        public string? ClieIdReprLegal { get; set; }
        public string? ClieJuridica { get; set; }
        public string? ClieLocalidad { get; set; }
        public string? ClieNit { get; set; }
        public string? CliePaginaWeb { get; set; }
        public string? CliePrimerNom { get; set; }
        public string? ClieRazonSocial { get; set; }
        public string? ClieReprLegal { get; set; }
        public string? ClieSegundoNom { get; set; }
        public string? ClieTelFijo { get; set; }

        //Referencias
        [Required]
        public CiudadDto? ClieCiudad { get; set; }
        public DeptoDto? ClieDepto { get; set; }
        public PaisDto? CliePais { get; set; }
        public EmpresaDto? ClieEmpresa { get; set; }
        public List<FacturaDto>? ClieFacturas { get; set; }
        public List<SucursalClienteDto>? ClieSucursalesCliente { get; set; }
        public List<ListaPrecioDto>? ClieListaPrecios { get; set; }
        public RegimenDto? ClieRegimen { get; set; }
        public RespFiscalDto? ClieRespFiscal { get; set; }
        public RespTributariaDto? ClieRespTributaria { get; set; }
        public TipoClienteDto? ClieTipoCliente { get; set; }
        public TipoIdDto? ClieTipoId { get; set; }
    }
}
