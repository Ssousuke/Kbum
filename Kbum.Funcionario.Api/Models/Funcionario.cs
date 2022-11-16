using System.ComponentModel.DataAnnotations;

namespace Kbum.Funcionario.Api.Models;
public class Funcionario
{
    [Key]
    public long FuncionarioId { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public bool Status { get; set; }
}
