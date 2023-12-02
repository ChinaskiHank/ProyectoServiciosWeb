
using ApiClientes.Models;
namespace ApiClientes.Repository
{
    public interface IClienteRepository
    {
        public Task<IEnumerable<Cliente>> GetClientes();
        public Task<IEnumerable<Cliente>> GetClientes(int page, int size);
        public Task<Cliente> GetClienteById(int clienteId);
        public Task<Cliente> CreateCliente(Cliente cliente);
        public Task<Cliente> UpdateCliente(Cliente cliente);
        public Task<bool> DeleteCliente(int clienteId);
        
    }
}
