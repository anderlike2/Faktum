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
        public DbSet<NumeracionResolucionModel> NumeracionResolucion { get; set; }
        public DbSet<LocalidadModel> Localidad { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<FormatoImpresionModel> FormatoImpresion { get; set; }
        public DbSet<UnidadModel> Unidad { get; set; }
        public DbSet<CentroCostoModel> CentroCosto { get; set; }
        public DbSet<ProductoModel> Producto { get; set; }
        public DbSet<FacturaModel> Factura { get; set; }
        public DbSet<DetalleFactModel> DetalleFact { get; set; }
        public DbSet<VendedorModel> Vendedor { get; set; }
        public DbSet<ListaPrecioModel> ListaPrecio { get; set; }
        public DbSet<NotaDebitoModel> NotaDebito { get; set; }
        public DbSet<NotaCreditoModel> NotaCredito { get; set; }
        public DbSet<SucursalModel> Sucursal { get; set; }
        public DbSet<SucursalClienteModel> sucursalCliente { get; set; }
    }
}
