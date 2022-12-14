using Kbum.Tarefas.Api.Models.Enums;
using Kbum.Tarefas.Api.Models;

namespace Kbum.Tarefas.Api.Data.Dto.MapearTarefaDto
{
    public class AtualizarMapeamentoDto
    {
        public string NomeDoMapemento { get; set; }
        public string DescricaoDoMapeamento { get; set; }
        public Tarefa? Tarefa { get; set; }
        public SubTarefa? SubTarefa { get; set; }
        public TipoMapeamento TipoMapeamento { get; set; }
    }
}
