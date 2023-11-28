﻿using DomainLayer.Models;

namespace DomainLayer.Dtos
{
    public class DeptoDto : BaseDto
    {
        public int DeptoCodigo { get; set; }
        public string? DeptoNombre { get; set; }

        //Referencias
        public List<CiudadDto>? DeptoCiudades { get; set; }
        public List<ClienteDto>? DeptoClientes { get; set; }
    }
}
