using Domain.Entities;

namespace Domain.ViewModel
{
    public class LivroVM //: ICloneable
    {
        public int Codl { get; set; }

        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public DateTime AnoPublicacao { get; set; }

        public ICollection<Autor> Autores { get; set; }
        public ICollection<Assunto> Assuntos { get; set; }

        /*
        public object Clone()
        {
            var livro = (LivroVM)MemberwiseClone();
            var assuntos = new List<AssuntoVM>();
            var autores = new List<AutorVM>();
            livro.Autores.ToList().ForEach(p => autores.Add((TelefoneView)p.Clone()));
            livro.Telefones = telefones;
            return livro;
        }
        */

    }
}
