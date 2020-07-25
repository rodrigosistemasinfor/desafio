using AutoMapper;
using DesafioApp.Domain;
using DesafioApp.Infra.Data.Entities;

namespace DesafioApp.Infra.CrossCutting
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UsuarioEntity, UsuarioDomain>();
            CreateMap<UsuarioDomain, UsuarioEntity>();
        }
    }
}
