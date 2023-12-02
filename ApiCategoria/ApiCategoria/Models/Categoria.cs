using static System.Net.Mime.MediaTypeNames;

namespace ApiCategoria.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? NomCategoria { get; set; }
        public string? CodCategoria { get; set; }
        public string? ImgCat { get; set; }
    }
}

