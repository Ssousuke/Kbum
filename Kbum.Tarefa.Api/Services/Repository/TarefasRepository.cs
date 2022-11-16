using Kbum.Tarefas.Api.Data.Dto.TarefaDto;
using Kbum.Tarefas.Api.Services.Interfaces;

namespace Kbum.Tarefas.Api.Services.Repository
{
    public class TarefasRepository : ITarefasRepository
    {
        public Task<AtualizarTarefaDto> AtualizarTarefa(AtualizarTarefaDto atualizarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<ListarTarefasDto> BuscarTarefaPorId()
        {
            throw new NotImplementedException();
        }

        public Task<CriarTarefaDto> CriarTarefa(CriarTarefaDto criarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarTarefa()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListarTarefasDto>> ListarTarefas()
        {
            throw new NotImplementedException();
        }
    }
}
