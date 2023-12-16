using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Assunto
    {
        [Key]
        public int CodAs { get; set; }
        public string Descricao { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
