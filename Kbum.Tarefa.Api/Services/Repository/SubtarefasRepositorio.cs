using Kbum.Tarefas.Api.Data.Dto.SubTarefaDto;
using Kbum.Tarefas.Api.Services.Interfaces;

namespace Kbum.Tarefas.Api.Services.Repository
{
    public class SubtarefasRepositorio : ISubtarefaRepository
    {
        public Task<AtualizarSubtarefaDto> AtualizarSubTarefa(AtualizarSubtarefaDto atualizarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<ListarSubTarefasDto> BuscarSubTarefaPorId()
        {
            throw new NotImplementedException();
        }

        public Task<CriarSubtarefaDto> CriarSubTarefa(CriarSubtarefaDto criarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarSubTarefa()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListarSubTarefasDto>> ListarSubTarefas()
        {
            throw new NotImplementedException();
        }
    }
}
