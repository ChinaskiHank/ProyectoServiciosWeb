using Microsoft.EntityFrameworkCore;
using ApiVentas.Models;
namespace ApiVentas.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
    }
}
