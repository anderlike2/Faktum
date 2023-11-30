using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class SucursalClienteModel : BaseEntity
    {
        [Required]
        public string? SuclDepto { get; set; }
        [Required]
        public string? SuclCiudad { get; set; }
        [Required]
        public string? SuclCodigo { get; set; }
        [Required]
        public string? SuclContacto { get; set; }
        [Required]
        public string? SuclCorreo { get; set; }
        [Required]
        public int SuclDiasPago { get; set; }
        [Required]
        public string? SuclListaPrecio { get; set; }
        [Required]
        public string? SuclNombre { get; set; }
        [Required]
        public string? SuclTelefono { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<ListaPrecioModel>? SuclListaPrecios { get; set; }
        [Required]
        public virtual EmpresaModel? SuclEmpresa { get; set; }
        [Required]
        public virtual ClienteModel? SuclCliente { get; set; }

        //Para creacion de datos mediante FK
        public virtual int SuclEmpresaId { get; set; }
        public virtual int SuclClienteId { get; set; }
    }
}
