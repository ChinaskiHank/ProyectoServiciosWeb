using Microsoft.Extensions.Logging;

namespace ApiVentas.Models
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public string? NombreCliente { get; set; }
        public string? ApellidoCliente { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }

        public ICollection<DetalleVenta>? DetalleVentas { get; set; }
    }

}
