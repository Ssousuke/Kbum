using System.ComponentModel;

namespace Kbum.Tarefas.Api.Models.Enums
{
    public enum TipoDeTarefa
    {
        [Description("Criado")]
        CRIADO = 1,

        [Description("Aguardando")]
        AGUARDANDO = 2,

        [Description("Em Desenvolvimento")]
        DESENVOLVIMENTO = 3,

        [Description("Concluido")]
        CONCLUIDO = 4,

        [Description("Cancelado")]
        CANCELADO = 5,

        [Description("Adiado")]
        ADIADO = 6,

        [Description("Em Analise")]
        EM_ANELISE = 7,

        [Description("Validando")]
        VALIDANDO = 8,
    }
}
