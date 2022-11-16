using Kbum.Tarefas.Api.Data.Dto.TarefaDto;

namespace Kbum.Tarefas.Api.Services.Interfaces
{
    public interface ITarefasRepository
    {
        Task<IEnumerable<ListarTarefasDto>> ListarTarefas();
        Task<ListarTarefasDto> BuscarTarefaPorId();
        Task<CriarTarefaDto> CriarTarefa(CriarTarefaDto criarTarefaDto);
        Task<AtualizarTarefaDto> AtualizarTarefa(AtualizarTarefaDto atualizarTarefaDto);
        Task<bool> DeletarTarefa();
    }
}
