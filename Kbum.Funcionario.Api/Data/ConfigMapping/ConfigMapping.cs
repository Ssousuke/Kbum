using AutoMapper;
using Kbum.Funcionario.Api.Data.Dto.FuncionarioDto;
namespace Kbum.Funcionario.Api.Data.ConfigMapping
{
    public class ConfigMapping
    {
        public static MapperConfiguration MapperConfiguration()
        {
            var mapping = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<Models.Funcionario, FuncCreate>().ReverseMap();
                    config.CreateMap<Models.Funcionario, FuncList>().ReverseMap();
                    config.CreateMap<Models.Funcionario, FuncDelete>().ReverseMap();
                    config.CreateMap<Models.Funcionario, FuncUpdate>().ReverseMap();
                }
            );
            return mapping;
        }
    }
}
