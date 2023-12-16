using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Livro
    {
        [Key]
        public int Codl { get; set; }

        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public string AnoPublicacao { get; set; }

        public ICollection<Autor> Autores { get; set; }
        public ICollection<Assunto> Assuntos { get; set; }
    }
}
