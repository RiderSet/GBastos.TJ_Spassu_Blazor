using Domain.Entities;

namespace Manager.Interfaces.Livros
{
    public interface ILivroRepository
    {
        Task<Livro> DeleteLivroAsync(int codl);
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
        Task<Livro> InsertLivroAsync(Livro Livro);
        Task<Livro> UpdateLivroAsync(Livro Livro);
    }
}
