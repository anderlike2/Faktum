namespace DomainLayer.Dtos
{
    public class ResolucionDto : BaseDto
    {
        public string? ResoAnio { get; set; }
        public long ResoConsActual { get; set; }
        public long ResoConsFinal { get; set; }
        public long ResoConsInicial { get; set; }
        public int ResoEstadoOperacion { get; set; }
        public DateTime ResoFecheExpide { get; set; }
        public string? ResoPrefijo { get; set; }
        public DateTime ResoVigencia { get; set; }

        //Referencias para consultas
        public int ResoNumeracionResolucionId { get; set; }
        public int ResoEmpresaId { get; set; }
        public int ResoSucursalId { get; set; }
        public int ResoTipoDocId { get; set; }
    }
}
