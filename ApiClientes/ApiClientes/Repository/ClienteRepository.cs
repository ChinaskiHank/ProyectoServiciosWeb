using ApiClientes.Models;
using ApiClientes.DbContexts;
using Microsoft.EntityFrameworkCore;
using ApiClientes.Exceptions;

namespace ApiClientes.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext dbContext;

        public  ClienteRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Cliente> CreateCliente(Cliente cliente)
        {
            dbContext.Clientes.Add(cliente);
            await dbContext.SaveChangesAsync();
            return cliente;
        }

        public async Task<bool> DeleteCliente(int clienteId)
        {
            var clientes = await dbContext.Clientes.FirstOrDefaultAsync(p => p.ClienteId == clienteId);
            if (clientes == null)
            {
                return false;
            }
            dbContext.Clientes.Remove(clientes);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> GetClienteById(int clienteId)
        {
            var cliente = await dbContext.Clientes.Where(p => p.ClienteId == clienteId).FirstOrDefaultAsync();
            if (cliente == null)
            {
                throw new NotFoundException($"Customer Not Found with ID {clienteId}");
            }
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await dbContext.Clientes.ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> GetClientes(int page, int size)
        {
            var result = await dbContext.Clientes.Skip(page * size).Take(size).ToListAsync();
            if (result == null)
            {
                throw new Exception();

            }
            else if (result.Count == 0)
            {
                throw new NotFoundException("Customer List is empty");
            }
            return result;
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            dbContext.Clientes.Update(cliente);
            await dbContext.SaveChangesAsync();
            return cliente;
        }
    }
}
