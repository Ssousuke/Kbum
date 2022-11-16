using Kbum.Tarefas.Api.Data.Dto.MapearTaredaDto;
using Kbum.Tarefas.Api.Data.Dto.SubTarefaDto;
using Kbum.Tarefas.Api.Data.Dto.TarefaDto;

namespace Kbum.Tarefas.Api.Services.Interfaces
{
    public interface IMapeamentoTarefa
    {
        Task<IEnumerable<ListarMapeamentosDto>> ListarMapeamentos();
        Task<ListarMapeamentosDto> BuscarMapeamentosPorId();
        Task<CriarMapeamentoDto> CriarMapeamento(CriarMapeamentoDto criarTarefaDto);
        Task<AtualizarMapeamentoDto> AtualizarMapeamento(AtualizarMapeamentoDto atualizarTarefaDto);
        Task<bool> DeletarSubTarefa();
    }
}
