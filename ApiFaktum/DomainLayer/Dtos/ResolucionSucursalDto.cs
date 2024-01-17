namespace DomainLayer.Dtos
{
    public class ResolucionSucursalDto : BaseDto
    {
        //Referencias
        public ResolucionDto? ResuResolucion { get; set; }
        public SucursalDto? ResuSucursal { get; set; }

        //Para consultas
        public int? ResuResolucionId { get; set; }
        public int? ResuSucursalId { get; set; }
    }
}
