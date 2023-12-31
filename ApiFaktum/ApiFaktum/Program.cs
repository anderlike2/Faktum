using DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using System.Text.Json.Serialization;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Connection String  

builder.Services.ConexionDataBases(builder.Configuration);

#endregion

#region Services Autentication  

builder.Services.AutenticacionJwt(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region Services Injected  

builder.Services.InyeccionServicios(builder.Configuration);

#endregion

#region User Identity

builder.Services.UserIdentity(builder.Configuration);

#endregion

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

#region Shows UseCors with CorsPolicyBuilder.

app.UseCors(builder =>
{
    builder
    .WithOrigins("http://170.247.0.104:2180")
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.Use(async (context, next) =>
{
    if (!context.User.Identity.IsAuthenticated)
    {
        var result = await context.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme);
        if (result?.Principal != null)
        {
            context.User = result.Principal;
        }
    }

    await next.Invoke();
});

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

app.Run();
