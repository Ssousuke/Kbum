using System.ComponentModel.DataAnnotations;

namespace Kbum.Usuarios.Api.Models;
public class Usuario
{
    [Key]
    public long UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
}
