using System.ComponentModel;

namespace Kbum.Tarefas.Api.Models.Enums
{
    public enum TipoDeSubTarefa
    {
        [Description("Reuniões")]
        REUNIAO = 1,

        [Description("Impedimentos")]
        Impedimentos = 2,
    }
}
