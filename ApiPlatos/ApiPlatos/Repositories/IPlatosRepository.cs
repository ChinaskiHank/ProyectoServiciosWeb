using ApiPlatos.Models;
namespace ApiPlatos.Repositories
{
    public interface IPlatosRepository
    {
        public Task<IEnumerable<Plato>> GetPlato();
        public Task<IEnumerable<Plato>> GetPlato(int page, int size);
        public Task<Plato> GetPlatoById(int platoId);
        public Task<Plato> CreatePlato(Plato plato);
        public Task<Plato> UpdatePlato(Plato plato);
        public Task<bool> DeletePlato(int platoId);
    }
}
