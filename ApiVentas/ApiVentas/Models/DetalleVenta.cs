
namespace ApiVentas.Models
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public int IdPlato { get; set; }
        public string? NombrePlato { get; set; }
        public decimal PrecioPlato { get; set; }   
        public int Cantidad { get; set; }
        public int VentaId { get; set; }
        public Venta? Venta { get; set; }
    }
}

