using ApiVentas.Models;
namespace ApiVentas.Repositories
{
    public interface IVentasRepository
    {
        public Task<IEnumerable<Venta>> GetVenta();
        public Task<bool> PlaceOrder(Venta venta);
    }
}
