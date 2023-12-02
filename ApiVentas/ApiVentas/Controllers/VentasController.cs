using Microsoft.AspNetCore.Mvc;
using ApiVentas.Repositories;
using ApiVentas.Models;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class VentasController
    {
        public IVentasRepository ventasRepository;

        public VentasController(IVentasRepository ventasRepository)
        {
            this.ventasRepository = ventasRepository;
        }
        [HttpGet]
        [Route("/GetVentas")]
        public async Task<bool> PlaceOrder(Venta venta)
        {
            return await ventasRepository.PlaceOrder(venta);
        }
    }
}
