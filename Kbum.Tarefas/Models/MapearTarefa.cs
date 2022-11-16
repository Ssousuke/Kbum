using Kbum.Tarefas.Api.Models.Enums;

namespace Kbum.Tarefas.Api.Models
{
    public class MapearTarefa
    {
        public Guid MapearTarefaId { get; set; }
        public string NomeDoMapemento { get; set; }
        public string DescricaoDoMapeamento { get; set; }
        public Tarefa? Tarefa { get; set; }
        public SubTarefa? SubTarefa { get; set; }
        public TipoMapeamento TipoMapeamento { get; set; }
    }
}
