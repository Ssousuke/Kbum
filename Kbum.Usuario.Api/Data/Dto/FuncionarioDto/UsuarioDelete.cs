namespace Kbum.Usuarios.Api.Data.Dto.FuncionarioDto
{
    public class UsuarioDelete
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Status { get; set; }
    }
}
