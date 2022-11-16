using System.ComponentModel;

namespace Kbum.Tarefas.Api.Models.Enums
{
    public enum NiveisDePrioridade
    {

        [Description("Nenhnuma")]
        NENHUMA = 1,

        [Description("Baixo")]
        BAIXO = 2,

        [Description("Médio")]
        MEDIO = 3,

        [Description("Alto")]
        ALTO = 3,

        [Description("Muito Alto")]
        MUITO_ALTO = 5,
    }
}
