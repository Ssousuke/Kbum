using Kbum.Tarefas.Api.Data.Dto.MapearTarefaDto;
using Kbum.Tarefas.Api.Services.Interfaces;

namespace Kbum.Tarefas.Api.Services.Repository
{
    public class MapeamentoRepository : IMapeamentoTarefa
    {
        public Task<AtualizarMapeamentoDto> AtualizarMapeamento(AtualizarMapeamentoDto atualizarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<ListarMapeamentosDto> BuscarMapeamentosPorId()
        {
            throw new NotImplementedException();
        }

        public Task<CriarMapeamentoDto> CriarMapeamento(CriarMapeamentoDto criarTarefaDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarSubTarefa()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ListarMapeamentosDto>> ListarMapeamentos()
        {
            throw new NotImplementedException();
        }
    }
}
