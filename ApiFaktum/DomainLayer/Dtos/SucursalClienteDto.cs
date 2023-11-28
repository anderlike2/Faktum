namespace DomainLayer.Dtos
{
    public class SucursalClienteDto : BaseDto
    {
        public string? SuclDepto { get; set; }
        public string? SuclCiudad { get; set; }
        public string? SuclCodigo { get; set; }
        public string? SuclContacto { get; set; }
        public string? SuclCorreo { get; set; }
        public int SuclDiasPago { get; set; }
        public string? SuclListaPrecio { get; set; }
        public string? SuclNombre { get; set; }
        public string? SuclTelefono { get; set; }

        //Referencias
        public List<ListaPrecioDto>? SuclListaPrecios { get; set; }
        public EmpresaDto? SuclEmpresa { get; set; }
        public ClienteDto? SuclCliente { get; set; }
    }
}
