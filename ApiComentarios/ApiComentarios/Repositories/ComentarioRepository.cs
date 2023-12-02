using ApiComentarios.Models;
using ApiComentarios.DbContexts;
using ApiComentarios.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ApiComentarios.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly AppDbContext dbContext;
        
        public ComentarioRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Comentario> CreateComentario(Comentario comentario)
        {
            dbContext.Comentarios.Add(comentario);
            await dbContext.SaveChangesAsync();
            return comentario;
        }

        public async Task<IEnumerable<Comentario>> GetComentario()
        {
            return await dbContext.Comentarios.ToListAsync();
        }
    }
}
