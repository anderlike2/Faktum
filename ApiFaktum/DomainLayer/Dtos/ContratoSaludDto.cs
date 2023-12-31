﻿namespace DomainLayer.Dtos
{
    public class ContratoSaludDto : BaseDto
    {
        public string? CosaContrato { get; set; }
        public string? CosaNitCliente { get; set; }
        public string? CosaPoliza { get; set; }

        //Referencias
        public int CosaClieIdId { get; set; }
        public int CosaCobeId { get; set; }
        public int CosaEmpresaId { get; set; }
        public int CosaMopaId { get; set; }
    }
}
