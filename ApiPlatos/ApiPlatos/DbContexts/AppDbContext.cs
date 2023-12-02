using Microsoft.EntityFrameworkCore;
using ApiPlatos.Models;
namespace ApiPlatos.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Plato> Platos { get; set; }
    }
}

