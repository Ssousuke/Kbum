using System.ComponentModel;

namespace Kbum.Tarefas.Api.Models.Enums
{
    public enum TipoMapeamento
    {
        [Description("Documentação")]
        DOCUMENTACAO = 1,

        [Description("Mapeamento")]
        MAPEAMENTO = 2,
    }
}
