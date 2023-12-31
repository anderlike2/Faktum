﻿namespace DomainLayer.Dtos
{
    public class CoberturaDto : BaseDto
    {
        public string? CobeCodigo { get; set; }
        public string? CobeNombre { get; set; }

        //Referencias
        public List<FacturaDto>? CobeFacturas { get; set; }
        public List<ContratoSaludDto>? CobeContratosSalud { get; set; }
    }
}
