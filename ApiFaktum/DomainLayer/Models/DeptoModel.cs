﻿
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class DeptoModel : BaseEntity
    {
        [Required]
        public int DeptoCodigo { get; set; }
        [Required]
        public string? DeptoNombre { get; set; }
        [Required]
        public virtual ICollection<CiudadModel>? DeptoCiudades { get; set; }
    }
}
