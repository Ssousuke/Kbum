using Kbum.Tarefas.Api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Kbum.Tarefas.Api.Models
{
    public class SubTarefa
    {
        [Key]
        public Guid SubTarefaId { get; set; }
        public string NomeDaSubTarefa { get; set; }
        public string DescricaoSubTarefa { get; set; }
        public int Etapa { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public DateTime DataDeAtualizacao { get; set; }
        public TipoDeSubTarefa TipoDeSubTarefa { get; set; }
    }
}
