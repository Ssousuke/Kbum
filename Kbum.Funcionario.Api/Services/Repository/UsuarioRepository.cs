using AutoMapper;
using Kbum.Usuarios.Api.Data.Context;
using Kbum.Usuarios.Api.Data.Dto.UsuarioionarioDto;
using Kbum.Usuarios.Api.Models;
using Kbum.Usuarios.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Kbum.Usuarios.Api.Services.Repository
{
    public class UsuarioRepository : IUsuarioionarioRepository
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public UsuarioRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioList>> ListarUsuarioionarios()
        {
            IEnumerable<Usuario> Usuarioionarios = await _context.Usuarios.ToArrayAsync();
            return _mapper.Map<IEnumerable<UsuarioList>>(Usuarioionarios);

        }
        public async Task<UsuarioCreate> AdicionarUsuarioionario(UsuarioCreate UsuarioCreate)
        {
            Models.Usuario Usuarioionario = _mapper.Map<Usuario>(UsuarioCreate);
            _context.Usuarios.Add(Usuarioionario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioCreate>(Usuarioionario);
        }

        public async Task<UsuarioUpdate> AtualizarUsuarioionario(UsuarioUpdate UsuarioUpdate)
        {
            Usuario usuario = _mapper.Map<Usuario>(UsuarioUpdate);
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioUpdate>(usuario);
        }

        public async Task<UsuarioList> BuscarPorId(long id)
        {
            Usuario Usuarioionario = await _context.Usuarios.Where(x => x.UsuarioId == id).FirstOrDefaultAsync();
            return _mapper.Map<UsuarioList>(Usuarioionario);
        }

        public async Task<bool> DeletarUsuarioionario(long id)
        {
            try
            {
                Usuario delUsuario = await _context.Usuarios.FindAsync(id);
                if (delUsuario != null)
                {
                    _context.Usuarios.Remove(delUsuario);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
