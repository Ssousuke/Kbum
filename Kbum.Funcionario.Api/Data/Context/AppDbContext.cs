using Kbum.Usuarios.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Kbum.Usuarios.Api.Data.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
