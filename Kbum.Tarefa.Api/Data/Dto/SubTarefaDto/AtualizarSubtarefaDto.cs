using Kbum.Tarefas.Api.Models.Enums;

namespace Kbum.Tarefas.Api.Data.Dto.SubTarefaDto
{
    public class AtualizarSubtarefaDto
    {
        public string NomeDaSubTarefa { get; set; }
        public string DescricaoSubTarefa { get; set; }
        public int Etapa { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeAtualizacao { get; set; }
        public TipoDeSubTarefa TipoDeSubTarefa { get; set; }
    }
}
