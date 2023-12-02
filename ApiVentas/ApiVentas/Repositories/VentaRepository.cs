using ApiVentas.DbContexts;
using ApiVentas.Models;

namespace ApiVentas.Repositories
{
    public class VentaRepository : IVentasRepository
    {
        private AppDbContext dbContext;

        public VentaRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> PlaceOrder(Venta venta)
        {
            try
            {
                dbContext.Ventas.Add(venta);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
