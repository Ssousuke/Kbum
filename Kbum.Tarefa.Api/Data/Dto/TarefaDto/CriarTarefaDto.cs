using Kbum.Tarefas.Api.Models.Enums;

namespace Kbum.Tarefas.Api.Data.Dto.TarefaDto
{
    public class CriarTarefaDto
    {
        public string NomeDaTarefa { get; set; }
        public string DescricaoDaTarefa { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public NiveisDePrioridade NiveisDePrioridade { get; set; }
        public TipoDeTarefa TipoDeTarefa { get; set; }
    }
}
