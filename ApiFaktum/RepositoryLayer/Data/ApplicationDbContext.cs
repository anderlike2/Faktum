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

        //Desarrollo Faktum
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
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ResolucionModel> Resolucion { get; set; }
        public DbSet<ContratoSaludModel> ContratoSalud { get; set; }
        public DbSet<EmpresasUsuarioModel> EmpresasUsuario { get; set; }
        public DbSet<OtroProductoModel> OtrosProductos { get; set; }
        public DbSet<ResolucionSucursalModel> ResolucionSucursal { get; set; }
        public DbSet<ListaPrecioProductoModel> ListaPrecioProducto { get; set; }

        //Desarrollo Rips
        //public DbSet<ObjetoRaiz> ObjetoRaiz { get; set; }
        public DbSet<ConsultaRips> ConsultaRips { get; set; }
        //public DbSet<EstadoRips> EstadoRips { get; set; }   
        //public DbSet<HospitalizacionRips> HospitalizacionRips { get; set; }
        //public DbSet<IncapacidadRips> IncapacidadRips { get; set; }
        //public DbSet<MedicamentosRips> MedicamentosRips { get; set; }
        //public DbSet<ModalidadAtencionRips> ModalidadAtencionRips { get; set; }
        //public DbSet<OrigenRips> OrigenRips { get; set;}
        //public DbSet<OtroServicioRips> OtroServicioRips { get; set; }
        //public DbSet<ProcedimientoRips> ProcedimientoRips { get; set; }
        //public DbSet<RecienNacidoRips> RecienNacidoRips { get; set; }
        //public DbSet<ServicioRips> ServicioRips { get; set; }
        //public DbSet<TipoDocRips> TipoDocRips { get; set; }
        //public DbSet<TipoNotaRips> TipoNotaRips { get; set; }
        //public DbSet<TipoOtroServicioRips> TipoOtroServicioRips { get; set; }
        //public DbSet<TipoUsuariosRips> TipoUsuariosRips { get; set; }
        //public DbSet<UrgenciaRips> UrgenciaRips { get; set; }
        //public DbSet<UsuarioRips> UsuarioRips { get; set; }
        public DbSet<UsuarioSaludRips> UsuarioSaludRips { get; set; }

    }
}
