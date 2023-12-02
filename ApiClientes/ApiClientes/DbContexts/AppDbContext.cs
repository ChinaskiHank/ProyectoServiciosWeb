using Microsoft.EntityFrameworkCore;
using ApiClientes.Models;
namespace ApiClientes.DbContexts
{
    public class AppDbContext:DbContext
    {   
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
    
}
