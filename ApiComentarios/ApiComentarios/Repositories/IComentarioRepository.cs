using ApiComentarios.Models;
namespace ApiComentarios.Repositories
{
    public interface IComentarioRepository
    {
        public Task<IEnumerable<Comentario>> GetComentario();
        public Task<Comentario> CreateComentario(Comentario comentario);
    }
}
