﻿namespace Kbum.Funcionario.Api.Data.Dto.FuncionarioDto
{
    public class FuncDelete
    {
        public long FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Status { get; set; }
    }
}
