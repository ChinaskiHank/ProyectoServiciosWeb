using Microsoft.AspNetCore.Mvc;
using ApiComentarios.Models;
using ApiComentarios.Repositories;
namespace ApiComentarios.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ComentarioController:ControllerBase
    {
        private readonly IComentarioRepository comentarioRepository;
        public ComentarioController(IComentarioRepository comentarioRepository)
        {
            this.comentarioRepository = comentarioRepository;
        }
        [HttpGet]
        [Route("GetComentarios")]
        public async Task<ActionResult<IEnumerable<Comentario>>> GetComentario()
        {
            return StatusCode(StatusCodes.Status200OK,await comentarioRepository.GetComentario());
        }
        [HttpPost]
        [Route("CreateComentario")]
        public async Task<ActionResult<Comentario>> CreateComentario(Comentario comentario)
        {
            return StatusCode(StatusCodes.Status201Created, await comentarioRepository.CreateComentario(comentario));
        }
    }
}
