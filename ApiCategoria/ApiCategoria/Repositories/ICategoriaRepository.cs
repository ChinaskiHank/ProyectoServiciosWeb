using ApiCategoria.Models;
namespace ApiCategoria.Repositories
{
    public interface ICategoriaRepository
    {
        public Task<IEnumerable<Categoria>> GetCategoria();
        public Task<Categoria> GetCategoriaById(int id);
        public Task<Categoria> CreateCategoria(Categoria categoria);
        public Task<Categoria> UpdateCategoria(Categoria categoria);
        public Task<bool> DeleteCategoria(int id);
    }
}
