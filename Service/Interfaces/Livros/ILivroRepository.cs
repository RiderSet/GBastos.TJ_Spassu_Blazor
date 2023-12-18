using Domain.Entities;

namespace Manager.Interfaces.Livros
{
    public interface ILivroRepository
    {
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
        Task<Livro> InsertLivroAsync(Livro livro);
        Task<Livro> UpdateLivroAsync(Livro livro);
        Task DeleteLivroAsync(int codl);
    }
}
