using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class ClasJuridicaModel : BaseEntity
    {
        [Required]
        public string? JuriCodigo { get; set; }
        [Required]
        public string? JuriNombre { get; set; }
        [Required]
        public int JuriEstadoOperacion { get; set; }

        //Referencias
        [Required]
        public virtual ICollection<EmpresaModel>? JuriEmpresas { get; set; }
        [Required]
        public virtual ICollection<ClasJuridicaModel>? JuriClasesJuridicas { get; set; }
    }
}
