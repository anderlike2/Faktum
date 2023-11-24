using DomainLayer.Models;

namespace RepositoryLayer.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));

            dbContext.Database.EnsureCreated();          

            //************************************
            //TipoDocumento
            //************************************
            if (!dbContext.TipoDocumentos.Any())
            {
                var tipoDocumentos = new TipoDocumento[]
                {
                    new TipoDocumento { Nombre = "Cédula", FechaCreacion = DateTime.UtcNow, Estado = 1 },
                    new TipoDocumento { Nombre = "Cédula extranjería", FechaCreacion = DateTime.UtcNow, Estado = 1 },
                    new TipoDocumento { Nombre = "Tarjeta Identidad", FechaCreacion = DateTime.UtcNow, Estado = 1 }
                };

                foreach (TipoDocumento s in tipoDocumentos)
                    dbContext.TipoDocumentos.Add(s);

                dbContext.SaveChanges();
            }       
        }
    }
}
