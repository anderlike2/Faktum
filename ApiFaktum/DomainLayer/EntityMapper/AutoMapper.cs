using AutoMapper;
using DomainLayer.Dtos;
using DomainLayer.Models;

namespace DomainLayer.EntityMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UsuarioModel, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioDto, UsuarioModel>();

            CreateMap<RolModel, RolDto>().ReverseMap();
            CreateMap<RolDto, RolModel>();

            CreateMap<RolesUsuarioModel, RolesUsuarioDto>().ReverseMap();
            CreateMap<RolesUsuarioDto, RolesUsuarioModel>();
        }
    }
}
