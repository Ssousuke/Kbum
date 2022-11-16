using Kbum.Funcionario.Api.Data.Dto.FuncionarioDto;
using Kbum.Funcionario.Api.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kbum.Funcionario.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        public IFuncionarioRepository _funcionarioRepository;

        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<FuncList>>> ListarFuncionarios()
        {
            IEnumerable<FuncList> funcionarios = await _funcionarioRepository.ListarFuncionarios();
            return Ok(funcionarios);
        }

        [HttpGet("buscar/{id}")]
        public async Task<ActionResult<FuncList>> BuscarPorId(long id)
        {
            FuncList funcionario = await _funcionarioRepository.BuscarPorId(id);
            return Ok(funcionario);
        }

        [HttpPost("adicionar")]
        public async Task<ActionResult<FuncCreate>> AdicionarFuncionario(FuncCreate funcCreate)
        {
            if (funcCreate == null)
                return BadRequest();
            FuncCreate funcionario = await _funcionarioRepository.AdicionarFuncionario(funcCreate);
            return Ok(funcionario);
        }

        [HttpPut("editar/{id}")]
        public async Task<ActionResult<FuncUpdate>> EditarFuncionario([FromBody] FuncUpdate funcUpdate)
        {
            if (funcUpdate == null) return BadRequest();
            var funcionario = await _funcionarioRepository.AtualizarFuncionario(funcUpdate);
            return Ok(funcionario);
        }

        [HttpDelete("deletar/{id}")]
        public async Task<ActionResult<bool>> DelatarFuncionario(long id)
        {
            await _funcionarioRepository.DeletarFuncionario(id);
            return Ok();
        }
    }
}
