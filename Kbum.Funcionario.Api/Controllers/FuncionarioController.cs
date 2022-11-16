using Kbum.Usuarios.Api.Data.Dto.UsuarioionarioDto;
using Kbum.Usuarios.Api.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kbum.Usuarios.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioionarioController : ControllerBase
    {
        public IUsuarioionarioRepository _UsuarioionarioRepository;

        public UsuarioionarioController(IUsuarioionarioRepository UsuarioionarioRepository)
        {
            _UsuarioionarioRepository = UsuarioionarioRepository;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<UsuarioList>>> ListarUsuarioionarios()
        {
            IEnumerable<UsuarioList> Usuarioionarios = await _UsuarioionarioRepository.ListarUsuarioionarios();
            return Ok(Usuarioionarios);
        }

        [HttpGet("buscar/{id}")]
        public async Task<ActionResult<UsuarioList>> BuscarPorId(long id)
        {
            UsuarioList Usuarioionario = await _UsuarioionarioRepository.BuscarPorId(id);
            return Ok(Usuarioionario);
        }

        [HttpPost("adicionar")]
        public async Task<ActionResult<UsuarioCreate>> AdicionarUsuarioionario(UsuarioCreate UsuarioCreate)
        {
            if (UsuarioCreate == null)
                return BadRequest();
            UsuarioCreate Usuarioionario = await _UsuarioionarioRepository.AdicionarUsuarioionario(UsuarioCreate);
            return Ok(Usuarioionario);
        }

        [HttpPut("editar/{id}")]
        public async Task<ActionResult<UsuarioUpdate>> EditarUsuarioionario([FromBody] UsuarioUpdate UsuarioUpdate)
        {
            if (UsuarioUpdate == null) return BadRequest();
            var Usuarioionario = await _UsuarioionarioRepository.AtualizarUsuarioionario(UsuarioUpdate);
            return Ok(Usuarioionario);
        }

        [HttpDelete("deletar/{id}")]
        public async Task<ActionResult<bool>> DelatarUsuarioionario(long id)
        {
            await _UsuarioionarioRepository.DeletarUsuarioionario(id);
            return Ok();
        }
    }
}
