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
        public int SuclDiasPago { get; set; }
        [Required]
        public string? SuclListaPrecio { get; set; }
        [Required]
        public string? SuclNombre { get; set; }
        [Required]
        public string? SuclTelefono { get; set; }

        [Required]
        public virtual ICollection<ListaPrecioModel>? SuclListaPrecios { get; set; }
        [Required]
        public virtual EmpresaModel? SuclEmpresa { get; set; }
    }
}
