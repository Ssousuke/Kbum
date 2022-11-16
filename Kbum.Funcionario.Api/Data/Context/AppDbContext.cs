using Microsoft.EntityFrameworkCore;

namespace Kbum.Funcionario.Api.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Models.Funcionario> Funcionarios { get; set; }
    }
}
