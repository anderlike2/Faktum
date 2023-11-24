using AutoMapper;
using DomainLayer.Dtos;
using DomainLayer.Models;

namespace DomainLayer.EntityMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<TipoDocumento, TipoDocumentoDto>().ReverseMap();
            CreateMap<TipoDocumentoDto, TipoDocumento>();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
