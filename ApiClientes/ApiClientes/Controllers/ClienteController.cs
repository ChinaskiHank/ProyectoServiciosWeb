using ApiClientes.Repository;
using Microsoft.AspNetCore.Mvc;
using ApiClientes.Models;
namespace ApiClientes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClienteController:ControllerBase
    {
        private readonly IClienteRepository clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
        [HttpGet]
        [Route("GetClientes")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return StatusCode(StatusCodes.Status200OK, await clienteRepository.GetClientes());
        }

        [HttpGet]
        [Route("GetClientes/page/{page}/size/{size}")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes(int page, int size)
        {
            return StatusCode(StatusCodes.Status200OK, await clienteRepository.GetClientes(page, size));
        }

        [HttpGet]
        [Route("GetClientesById/{id}")]
        public async Task<ActionResult<Cliente>> GetClientesById(int clienteId)
        {
            return StatusCode(StatusCodes.Status200OK, await clienteRepository.GetClienteById(clienteId));
        }

        [HttpPost]
        [Route("CrearCliente")]
        public async Task<ActionResult<Cliente>> CreateCustomer(Cliente cliente)
        {
            return StatusCode(StatusCodes.Status201Created, await clienteRepository.CreateCliente(cliente));

        }

        [HttpPut]
        [Route("ActualizarCliente")]
        public async Task<ActionResult<Cliente>> UpdateCustomer(Cliente cliente)
        {
            return StatusCode(StatusCodes.Status200OK, await clienteRepository.UpdateCliente(cliente));
        }

        [HttpDelete]
        [Route("EliminarCliente")]
        public async Task<ActionResult<bool>> DeleteCustomer(int clienteId)
        {
            return StatusCode(StatusCodes.Status200OK, await clienteRepository.DeleteCliente(clienteId));
        }

    }
    
}
