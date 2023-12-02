using Microsoft.AspNetCore.Mvc;
using ApiVentas.Repositories;
using ApiVentas.Models;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class VentasController:ControllerBase
    {
        public IVentasRepository ventasRepository;

        public VentasController(IVentasRepository ventasRepository)
        {
            this.ventasRepository = ventasRepository;
        }

        [HttpGet]
        [Route("ListaVentas")]
        public async Task<ActionResult<IEnumerable<DetalleVenta>>> GetVenta()
        {
            return StatusCode(StatusCodes.Status200OK, await ventasRepository.GetVenta());
        }
        [HttpPost]
        [Route("GetVentas")]
        public async Task<bool> PlaceOrder(Venta venta)
        {
            return await ventasRepository.PlaceOrder(venta);
        }
    }
}
