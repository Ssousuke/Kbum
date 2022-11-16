using AutoMapper;
using Kbum.Usuarios.Api.Data.Dto.UsuarioionarioDto;
using Kbum.Usuarios.Api.Models;

namespace Kbum.Usuarios.Api.Data.ConfigMapping
{
    public class ConfigMapping
    {
        public static MapperConfiguration MapperConfiguration()
        {
            var mapping = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<Usuario, UsuarioCreate>().ReverseMap();
                    config.CreateMap<Usuario, UsuarioList>().ReverseMap();
                    config.CreateMap<Usuario, UsuarioDelete>().ReverseMap();
                    config.CreateMap<Usuario, UsuarioUpdate>().ReverseMap();
                }
            );
            return mapping;
        }
    }
}
