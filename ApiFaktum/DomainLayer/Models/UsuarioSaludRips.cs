using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{

    public class UsuarioSaludRips : BaseEntity
    {
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public string? UsUaNumeroDoc { get; set; }
        [Required]
        public DateTime? UsUaFechaNac { get; set; }
        [Required]
        [MaxLength(1)]
        public string? UsUaSexo { get; set; }
        [Required]
        [MaxLength(50)]
        public string? UsUaPrimerNombre { get; set; }
        [MaxLength(50)]
        public string? UsUaSegundoNombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string? UsUaPrimerApellido { get; set; }
        [Required]
        public string? UsUaSegundoApellido { get; set; }
        [Required]
        [MaxLength(2)]
        public string? UsUaZonaTerritorial { get; set; }
        [Required]
        [MaxLength(2)]
        public string? UsUaIncapacidad { get; set; }
        [Required]
        [MaxLength(10)]
        public string? UsUaTelefono { get; set; }
        [Required]
        [MaxLength(250)]
        public string? UsUaDireccion { get; set; }


        public virtual int UsUaTipoDocRipsId { get; set; }
        public virtual int UsUaTipoUsuarioRips { get; set; }
        public virtual int UsUaCiudadResidenciaId { get; set; }
        public virtual int UsUaPaisNacimientoId { get; set; }


        [Required]
        public virtual TipoDocRips? UsUaTipoDocRips { get; set; }
        [Required]
        public virtual TipoUsuariosRips? UsUaTipoUsuariosRips { get; set; }
        [Required]
        public virtual CiudadModel? UsUaCiudadResicencia { get; set; }
        [Required]
        public virtual CiudadModel? UsUaPaisNacimiento { get; set; }

    }
}
