using ApiCategoria.Models;
using ApiCategoria.DbContexts;
using Microsoft.EntityFrameworkCore;
using ApiCategoria.Exceptions;

namespace ApiCategoria.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext dbContext;

        public CategoriaRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Categoria> CreateCategoria(Categoria categoria)
        {
            dbContext.Categorias.Add(categoria);
            await dbContext.SaveChangesAsync();
            return categoria;
        }

        public async Task<bool> DeleteCategoria(int id)
        {
            var categorias = await dbContext.Categorias.FirstOrDefaultAsync(p => p.CategoriaId == id);
            if (categorias == null)
            {
                return false;
            }
            dbContext.Categorias.Remove(categorias);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Categoria>> GetCategoria()
        {
            return await dbContext.Categorias.ToListAsync();
        }

        public async Task<Categoria> GetCategoriaById(int id)
        {
            var categoria = await dbContext.Categorias.Where(p => p.CategoriaId == id).FirstOrDefaultAsync();
            if (categoria == null)
            {
                throw new NotFoundException($"Categoria no encontrada con ID {id}");
            }
            return categoria;
        }

        public async Task<Categoria> UpdateCategoria(Categoria categoria)
        {
            dbContext.Categorias.Update(categoria);
            await dbContext.SaveChangesAsync();
            return categoria;
        }
    }
}
