using Microsoft.EntityFrameworkCore;
using ApiComentarios.Models;
namespace ApiComentarios.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options){

        }
        public DbSet<Comentario> Comentarios { get; set; }
    }
}
