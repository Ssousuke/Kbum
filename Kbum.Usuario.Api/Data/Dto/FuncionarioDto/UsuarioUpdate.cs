namespace Kbum.Usuarios.Api.Data.Dto.FuncionarioDto
{
    public class UsuarioUpdate
    {
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Status { get; set; }
    }
}
