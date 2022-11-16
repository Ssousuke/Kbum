using Kbum.Funcionario.Api.Data.Dto.FuncionarioDto;

namespace Kbum.Funcionario.Api.Services.Interface
{
    public interface IFuncionarioRepository
    {
        Task<IEnumerable<FuncList>> ListarFuncionarios();
        Task<FuncList> BuscarPorId(long id);
        Task<FuncCreate> AdicionarFuncionario(FuncCreate funcCreate);
        Task<FuncUpdate> AtualizarFuncionario(FuncUpdate funcUpdate);
        Task<bool> DeletarFuncionario(long id);
    }
}
