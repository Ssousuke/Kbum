using Kbum.Usuarios.Api.Data.Dto.FuncionarioDto;

namespace Kbum.Usuarios.Api.Services.Interface
{
    public interface IUsuarioionarioRepository
    {
        Task<IEnumerable<UsuarioList>> ListarUsuarioionarios();
        Task<UsuarioList> BuscarPorId(long id);
        Task<UsuarioCreate> AdicionarUsuarioionario(UsuarioCreate UsuarioCreate);
        Task<UsuarioUpdate> AtualizarUsuarioionario(UsuarioUpdate UsuarioUpdate);
        Task<bool> DeletarUsuarioionario(long id);
    }
}
