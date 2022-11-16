using Kbum.Tarefas.Api.Data.Dto.SubTarefaDto;
using Kbum.Tarefas.Api.Data.Dto.TarefaDto;

namespace Kbum.Tarefas.Api.Services.Interfaces
{
    public interface ISubtarefaRepository
    {
        Task<IEnumerable<ListarSubTarefasDto>> ListarSubTarefas();
        Task<ListarSubTarefasDto> BuscarSubTarefaPorId();
        Task<CriarSubtarefaDto> CriarSubTarefa(CriarSubtarefaDto criarTarefaDto);
        Task<AtualizarSubtarefaDto> AtualizarSubTarefa(AtualizarSubtarefaDto atualizarTarefaDto);
        Task<bool> DeletarSubTarefa();
    }
}
