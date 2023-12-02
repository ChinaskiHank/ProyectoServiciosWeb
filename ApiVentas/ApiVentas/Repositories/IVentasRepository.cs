using ApiVentas.Models;
namespace ApiVentas.Repositories
{
    public interface IVentasRepository
    {
        public Task<bool> PlaceOrder(Venta venta);
    }
}
