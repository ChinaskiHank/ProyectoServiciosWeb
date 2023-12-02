using ApiPlatos.Models;
using ApiPlatos.DbContexts;
using Microsoft.EntityFrameworkCore;
using ApiPlatos.Exceptions;

namespace ApiPlatos.Repositories
{
    public class PlatosRepository : IPlatosRepository 
    {
        private readonly AppDbContext dbContext;

        public PlatosRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Plato> CreatePlato(Plato plato)
        {
            dbContext.Platos.Add(plato);
            await dbContext.SaveChangesAsync();
            return plato;
        }

        public async Task<bool> DeletePlato(int platoId)
        {
            var platos = await dbContext.Platos.FirstOrDefaultAsync(p => p.PlatoId == platoId);
            if (platos == null)
            {
                return false;
            }
            dbContext.Platos.Remove(platos);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Plato>> GetPlato()
        {
            return await dbContext.Platos.ToListAsync();
        }

        public async Task<IEnumerable<Plato>> GetPlato(int page, int size)
        {
            var result = await dbContext.Platos.Skip(page * size).Take(size).ToListAsync();
            if (result == null)
            {
                throw new Exception();

            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Lista de platos vacia");
            }
            return result;
        }

        public async Task<IEnumerable<Plato>> GetPlatosByCategoria(int id)
        {
            var result = await dbContext.Platos.Where(p => p.categoria == id).ToListAsync();
            if (result == null)
            {
                throw new Exception();

            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Lista de platos vacia");
            }
            return result;
        }

        public async Task<Plato> GetPlatoById(int platoId)
        {
            var cliente = await dbContext.Platos.Where(p => p.PlatoId == platoId).FirstOrDefaultAsync();
            if (cliente == null)
            {
                throw new NotFoundException($"Plato no encontrado con ID {platoId}");
            }
            return cliente;
        }

        public async Task<Plato> UpdatePlato(Plato plato)
        {
            dbContext.Platos.Update(plato);
            await dbContext.SaveChangesAsync();
            return plato;
        }
    }
}
