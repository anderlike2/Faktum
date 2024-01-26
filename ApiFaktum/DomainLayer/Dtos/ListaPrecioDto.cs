namespace DomainLayer.Dtos
{
    public class ListaPrecioDto : BaseDto
    {
        public string? LiprDescripcion { get; set; }
        public int LiprEstadoOperacion { get; set; }
        public string? LiprNombre { get; set; }

        //Referencias para Consultas
        public int LiprEmpresaId { get; set; }
    }
}
