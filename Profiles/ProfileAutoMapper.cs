using AutoMapper;
using CruddDapperWebApi.Dto;
using CruddDapperWebApi.Models;

namespace CruddDapperWebApi.Profiles
{
    public class ProfileAutoMapper : Profile 
    {
        public ProfileAutoMapper()
        {
            CreateMap<Usuario, UsuarioListarDto>().ReverseMap();
        }
    }
}
