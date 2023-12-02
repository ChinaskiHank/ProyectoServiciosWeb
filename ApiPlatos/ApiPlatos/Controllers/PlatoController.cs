using Microsoft.AspNetCore.Mvc;
using ApiPlatos.Models;
using ApiPlatos.Repositories;
namespace ApiPlatos.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlatoController:ControllerBase
    {
        private readonly IPlatosRepository platosRepository;
        public PlatoController(IPlatosRepository platosRepository)
        {
            this.platosRepository = platosRepository;
        }
        [HttpGet]
        [Route("GetPlatos")]
        public async Task<ActionResult<IEnumerable<Plato>>> GetPlato()
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.GetPlato());
        }

        [HttpGet]
        [Route("GetPlatos/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Plato>>> GetPlato(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.GetPlato(page, size));
        }

        [HttpGet]
        [Route("GetPlatosById/")]
        public async Task<ActionResult<Plato>> GetPlatoById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.GetPlatoById(id));
        }

        [HttpGet]
        [Route("GetPlatosByCategoria/{id}")]
        public async Task<ActionResult<IEnumerable<Plato>>> GetPlatosByCategoria(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.GetPlatosByCategoria(id));
        }

        [HttpPost]
        [Route("CrearPlato")]
        public async Task<ActionResult<Plato>> CreatePlatos(Plato plato)
        {
            return StatusCode(StatusCodes.Status201Created, await platosRepository.CreatePlato(plato));

        }

        [HttpPut]
        [Route("ActualizarPlato")]
        public async Task<ActionResult<Plato>> UpdatePLatos(Plato plato)
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.UpdatePlato(plato));
        }

        [HttpDelete]
        [Route("EliminarPlato")]
        public async Task<ActionResult<bool>> DeletePlatos(int platoId)
        {
            return StatusCode(StatusCodes.Status200OK, await platosRepository.DeletePlato(platoId));
        }

    }
}
