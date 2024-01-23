using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    
      public class UsuarioSaludRips
    {
        public int? UsUaId { get; set; }
        public string? UsUaEmpresa { get; set; }
        public string? UsUaTipoDocRips { get; set; }
        public string? UsUaNumeroDoc { get; set; }
        public string? UsUaTipoUsuario { get; set; }
        public DateTime? UsUaFechaNac { get; set; }
        public string? UsUaSexo { get; set; }
        public string? UsUaPrimerNombre { get; set; }
        public string? UsUaSegundoNombre { get; set; }
        public string? UsUaPrimerApellido { get; set; }
        public string? UsUaSegundoApellido { get; set; }
        public string? UsUaPaisNacimiento { get; set; }
        public string? UsUaPaisResidencia { get; set; }
        public string? UsUaAdepto { get; set; }
        public string? UsUaCiudad { get; set; }
        public string? UsUaZonaTerritorial { get; set; }
        public string? UsUaDireccion { get; set; }
        public string? UsUaATelefono { get; set; }
    }
}
