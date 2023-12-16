using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Autor
    {
        [Key]
        public int CodAu { get; set; }
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
