using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class ClienteModel : BaseEntity
    {
        public string? ClieApellidos { get; set; }
        [Required]
        public string? ClieCelular { get; set; }
        public string? ClieCiuu { get; set; }
        [Required]
        public string? ClieCobertura { get; set; }
        [Required]
        public string? ClieContacto { get; set; }
        [Required]
        public string? ClieCorreo { get; set; }
        [Required]
        public string? ClieCorreoFact { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ClieDescGlobal { get; set; }
        [Required]
        public int ClieDiasPago{ get; set; }
        [Required]
        public string? ClieDireccion { get; set; }
        [Required]
        public long ClieDv { get; set; }
        [Required]
        public int ClieEstadoOperacion { get; set; }
        [Required]
        public string? ClieIdReprLegal { get; set; }
        [Required]
        public string? ClieJuridica { get; set; }
        public string? ClieLocalidad { get; set; }
        [Required]
        public string? ClieNit { get; set; }
        public string? CliePaginaWeb { get; set; }
        public string? CliePrimerNom { get; set; }
        [Required]
        public string? ClieRazonSocial { get; set; }
        [Required]
        public string? ClieReprLegal { get; set; }
        public string? ClieSegundoNom { get; set; }
        public string? ClieTelFijo { get; set; }

        //Referencias
        [Required]
        public virtual CiudadModel? ClieCiudad { get; set; }
        [Required]
        public virtual DeptoModel? ClieDepto { get; set; }
        [Required]
        public virtual PaisModel? CliePais { get; set; }
        [Required]
        public virtual EmpresaModel? ClieEmpresa { get; set; }
        [Required]
        public virtual ICollection<FacturaModel>? ClieFacturas { get; set; }
        [Required]
        public virtual ICollection<SucursalClienteModel>? ClieSucursalesCliente { get; set; }
        [Required]
        public virtual ICollection<ListaPrecioModel>? ClieListaPrecios { get; set; }
        [Required]
        public virtual RegimenModel? ClieRegimen { get; set; }
        [Required]
        public virtual RespFiscalModel? ClieRespFiscal { get; set; }
        [Required]
        public virtual RespTributariaModel? ClieRespTributaria { get; set; }
        [Required]
        public virtual TipoClienteModel? ClieTipoCliente { get; set; }
        [Required]
        public virtual TipoIdModel? ClieTipoId { get; set; }
        [Required]
        public virtual ICollection<ContratoSaludModel>? ClieContratosSalud { get; set; }
    }
}
