using Kbum.Tarefas.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Kbum.Tarefas.Api.Models
{
    public class Tarefa
    {
        [Key]
        public Guid TarefaId { get; set; }
        public string NomeDaTarefa { get; set; }
        public string DescricaoDaTarefa { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataDeConclusao { get; set; }
        public NiveisDePrioridade NiveisDePrioridade { get; set; }
        public TipoDeTarefa TipoDeTarefa { get; set; }
    }
}
