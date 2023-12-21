namespace Domain.ViewModel
{
    /// <summary>
    /// Objeto utilizado para inserção de um novo livro.
    /// </summary>
    public class CreateLivroVM
    {
        /// <summary>
        /// Titulo do livro
        /// </summary>
        /// <example>A origem das espécies</example>
        public string Titulo { get; set; }

        /// <summary>
        /// Editora do livro
        /// </summary>
        /// <example>Abril</example>
        public string Editora { get; set; }

        /// <summary>
        /// Número da edição do livro
        /// </summary>
        /// <example>1</example>
        public int Edicao { get; set; }

        /// <summary>
        /// Ano da publicação do livro
        /// </summary>
        /// <example>1970</example>
        public string AnoPublicacao { get; set; }
    }
}