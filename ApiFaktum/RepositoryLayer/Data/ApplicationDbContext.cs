using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //Relaciones de tablas
            modelBuilder.Entity<CiudadModel>()
               .HasOne(b => b.Depto)
               .WithMany(a => a.Ciudades)
               .HasForeignKey(b => b.CiudDepto);

            modelBuilder.Entity<RolUsuarioModel>()
               .HasOne(b => b.Usuario)
               .WithMany(a => a.Roles)
               .HasForeignKey(b => b.RousUsuario);

            modelBuilder.Entity<RolUsuarioModel>()
               .HasOne(b => b.Rol)
               .WithMany(a => a.Roles)
               .HasForeignKey(b => b.RousRol);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<RolModel> Rol { get; set; }
        public DbSet<RolUsuarioModel> RolUsuario { get; set; }
        public DbSet<DeptoModel> Depto { get; set; }
        public DbSet<CiudadModel> Ciudad { get; set; }
        public DbSet<ClasJuridicaModel> ClasJuridica { get; set; }
        public DbSet<CoberturaModel> Cobertura { get; set; }
        public DbSet<ConceptoNotaModel> ConceptoNota { get; set; }
        public DbSet<CondicionVentaModel> CondicionVenta { get; set; }
        public DbSet<CumModel> Cum { get; set; }
        public DbSet<CupModel> Cup { get; set; }
        public DbSet<EstadoDianFacturaModel> EstadoDianFactura { get; set; }
        public DbSet<FactSaludTipoModel> FactSaludTipo { get; set; }
        public DbSet<FormaPagoModel> FormaPago { get; set; }
        public DbSet<ImpuestoModel> Impuesto { get; set; }
        public DbSet<IumModel> Ium { get; set; }
        public DbSet<ModalidadPagoModel> ModalidadPago { get; set; }
        public DbSet<PaisModel> Pais { get; set; }
        public DbSet<RegimenModel> Regimen { get; set; }
        public DbSet<RespFiscalModel> RespFiscal { get; set; }
        public DbSet<RespTributariaModel> RespTributaria { get; set; }
        public DbSet<ReteFuenteModel> ReteFuente { get; set; }
        public DbSet<TipoArchivoRipsModel> TipoArchivoRips { get; set; }
        public DbSet<TipoDescuentoModel> TipoDescuento { get; set; }
        public DbSet<TipoIdModel> TipoId { get; set; }
        public DbSet<MonedaModel> Moneda { get; set; }
        public DbSet<TipoDocElectrModel> TipoDocElectr { get; set; }
        public DbSet<TipoCupModel> TipoCup { get; set; }
        public DbSet<TipoClienteModel> TipoCliente { get; set; }
        public DbSet<ClaseFacturaModel> ClaseFactura { get; set; }
        public DbSet<NumeracionResolucionModel> numeracionResolucion { get; set; }
        public DbSet<LocalidadModel> Localidad { get; set; }
    }
}
