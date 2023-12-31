﻿namespace DomainLayer.Dtos
{
    public class TipoDescuentoDto : BaseDto
    {
        public string? TideCodigo { get; set; }
        public string? TideNombre { get; set; }

        //Referencias
        public List<FacturaDto>? TideFacturas { get; set; }
        public List<CentroCostoDto>? TideCentrosCostos { get; set; }
    }
}
