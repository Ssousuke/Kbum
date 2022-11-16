using AutoMapper;
using Kbum.Funcionario.Api.Data.Context;
using Kbum.Funcionario.Api.Data.Dto.FuncionarioDto;
using Kbum.Funcionario.Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Kbum.Funcionario.Api.Services.Repository
{
    public class FuncRepository : IFuncionarioRepository
    {
        private readonly AppDbContext _context;
        private IMapper _mapper;

        public FuncRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FuncList>> ListarFuncionarios()
        {
            IEnumerable<Models.Funcionario> funcionarios = await _context.Funcionarios.ToArrayAsync();
            return _mapper.Map<IEnumerable<FuncList>>(funcionarios);

        }
        public async Task<FuncCreate> AdicionarFuncionario(FuncCreate funcCreate)
        {
            Models.Funcionario funcionario = _mapper.Map<Models.Funcionario>(funcCreate);
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
            return _mapper.Map<FuncCreate>(funcionario);
        }

        public async Task<FuncUpdate> AtualizarFuncionario(FuncUpdate funcUpdate)
        {
            Models.Funcionario func = _mapper.Map<Models.Funcionario>(funcUpdate);
            _context.Funcionarios.Update(func);
            await _context.SaveChangesAsync();
            return _mapper.Map<FuncUpdate>(func);
        }

        public async Task<FuncList> BuscarPorId(long id)
        {
            Models.Funcionario funcionario = await _context.Funcionarios.Where(x => x.FuncionarioId == id).FirstOrDefaultAsync();
            return _mapper.Map<FuncList>(funcionario);
        }

        public async Task<bool> DeletarFuncionario(long id)
        {
            try
            {
                Models.Funcionario delFunc = await _context.Funcionarios.FindAsync(id);
                if (delFunc != null)
                {
                    _context.Funcionarios.Remove(delFunc);
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
