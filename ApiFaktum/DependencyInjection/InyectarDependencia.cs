using Commun.Helpers;
using Commun.Logger;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer.Data;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.IService;
using ServiceLayer.Service;
using System.Text;

namespace DependencyInjection
{
    public static class InyectarDependencia
    {
        public static void ConexionDataBases(this IServiceCollection services, IConfiguration Configuration)
        {
            string dbConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(dbConnectionString));

            services.AddScoped<DbInitializer>();
        }

        public static void AutenticacionJwt(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddControllers();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,

                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,

                    ValidAudience = JwtSettings.Jwt_Audience,
                    ValidIssuer = JwtSettings.Jwt_Issuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.Jwt_SecretPassword))
                };
            });
        }

        public static void InyeccionServicios(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped(typeof(ICreateLogger), typeof(CreateLogger));

            services.AddScoped(typeof(IUsuarioRepository), typeof(UsuarioRepository));
            services.AddScoped(typeof(IMaestrasRepository), typeof(MaestrasRepository));
            services.AddScoped(typeof(IReteFuenteRepository), typeof(ReteFuenteRepository));
            services.AddScoped(typeof(ICumRepository), typeof(CumRepository));
            services.AddScoped(typeof(IRegimenRepository), typeof(RegimenRepository));
            services.AddScoped(typeof(IIumRepository), typeof(IumRepository));
            services.AddScoped(typeof(IClasJuridicaRepository), typeof(ClasJuridicaRepository));
            services.AddScoped(typeof(IImpuestoRepository), typeof(ImpuestoRepository));
            services.AddScoped(typeof(ICiudadRepository), typeof(CiudadRepository));
            services.AddScoped(typeof(IDeptoRepository), typeof(DeptoRepository));
            services.AddScoped(typeof(IRolRepository), typeof(RolRepository));
            services.AddScoped(typeof(IEmpresaRepository), typeof(EmpresaRepository));
            services.AddScoped(typeof(ISucursalRepository), typeof(SucursalRepository));
            services.AddScoped(typeof(ICentroCostoRepository), typeof(CentroCostoRepository));
            services.AddScoped(typeof(IUsuarioEmpresaRepository), typeof(UsuarioEmpresaRepository));
            services.AddScoped(typeof(IRolUsuarioRepository), typeof(RolUsuarioRepository));
            services.AddScoped(typeof(IClienteRepository), typeof(ClienteRepository));
            services.AddScoped(typeof(IContratosSaludRepository), typeof(ContratosSaludRepository));
            services.AddScoped(typeof(IProductoRepository), typeof(ProductoRepository));
            services.AddScoped(typeof(IListaPreciosRepository), typeof(ListaPreciosRepository));
            services.AddScoped(typeof(IResolucionRepository), typeof(ResolucionRepository));
            services.AddScoped(typeof(IFormatoImpresionRepository), typeof(FormatoImpresionRepository));
            services.AddScoped(typeof(IUnidadRepository), typeof(UnidadRepository));
            services.AddScoped(typeof(IOtroProductoRepository), typeof(OtroProductoRepository));
            services.AddScoped(typeof(IFacturaRepository), typeof(FacturaRepository));
            services.AddScoped(typeof(IDetalleFacturaRepository), typeof(DetalleFacturaRepository));

            services.AddScoped(typeof(IUsuarioService), typeof(UsuarioService));
            services.AddScoped(typeof(IMaestrasService), typeof(MaestrasService));
            services.AddScoped(typeof(IEmpresaService), typeof(EmpresaService));
            services.AddScoped(typeof(ISucursalService), typeof(SucursalService));
            services.AddScoped(typeof(ICentroCostoService), typeof(CentroCostoService));
            services.AddScoped(typeof(IClienteService), typeof(ClienteService));
            services.AddScoped(typeof(IContratosSaludService), typeof(ContratosSaludService));
            services.AddScoped(typeof(IProductoService), typeof(ProductoService));
            services.AddScoped(typeof(IListaPreciosService), typeof(ListaPreciosService));
            services.AddScoped(typeof(IResolucionService), typeof(ResolucionService));
            services.AddScoped(typeof(IFormatoImpresionService), typeof(FormatoImpresionService));
            services.AddScoped(typeof(ICiudadService), typeof(CiudadService));
            services.AddScoped(typeof(IUnidadService), typeof(UnidadService));
            services.AddScoped(typeof(IOtroProductoService), typeof(OtroProductoService));
            services.AddScoped(typeof(IFacturaService), typeof(FacturaService));

            services.AddTransient<IAuthToken, AuthToken>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public static void UserIdentity(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}