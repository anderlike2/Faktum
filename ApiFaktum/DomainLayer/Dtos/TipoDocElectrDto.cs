﻿namespace DomainLayer.Dtos
{
    public class TipoDocElectrDto : BaseDto
    {
        public string? TidoCodigo { get; set; }
        public string? TidoNombre { get; set; }

        //Referencias
        public List<FacturaDto>? TidoFacturas { get; set; }
        public List<ResolucionDto>? TidoResoluciones { get; set; }
    }
}
