using Microsoft.EntityFrameworkCore;
using ApiCategoria.Models;
namespace ApiCategoria.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options) 
        {
        
        }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
