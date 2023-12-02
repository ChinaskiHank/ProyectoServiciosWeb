namespace ApiPlatos.Models
{
    public class Plato
    {
        public int PlatoId { get; set; }
        public string? NomPlato { get; set; }
        public string? Descripcion { get; set; }
        public double Precio { get; set; }
        public string? CategoriaNombre { get; set; }
        public int categoria { get; set; }
        public string? imagen { get; set; }

    }

}
