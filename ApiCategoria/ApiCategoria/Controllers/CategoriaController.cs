using Microsoft.AspNetCore.Mvc;
using ApiCategoria.Models;
using ApiCategoria.Repositories;
namespace ApiCategoria.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoriaController:ControllerBase
    {
        private readonly ICategoriaRepository categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            this.categoriaRepository = categoriaRepository;
        }
        [HttpGet]
        [Route("GetCategoria")]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria()
        {
            return StatusCode(StatusCodes.Status200OK, await categoriaRepository.GetCategoria());
        }


        [HttpGet]
        [Route("GeCategoriaById/{id}")]
        public async Task<ActionResult<Categoria>> GetCategoriaById(int clienteId)
        {
            return StatusCode(StatusCodes.Status200OK, await categoriaRepository.GetCategoriaById(clienteId));
        }

        [HttpPost]
        [Route("CrearCategoria")]
        public async Task<ActionResult<Categoria>> CreatePlatos(Categoria categoria)
        {
            return StatusCode(StatusCodes.Status201Created, await categoriaRepository.CreateCategoria(categoria));

        }

        [HttpPut]
        [Route("ActualizarCategoria")]
        public async Task<ActionResult<Categoria>> UpdatePLatos(Categoria categoria)
        {
            return StatusCode(StatusCodes.Status200OK, await categoriaRepository.UpdateCategoria(categoria));
        }

        [HttpDelete]
        [Route("EliminarCategoria")]
        public async Task<ActionResult<bool>> DeletePlatos(int platoId)
        {
            return StatusCode(StatusCodes.Status200OK, await categoriaRepository.DeleteCategoria(platoId));
        }
    }
}
