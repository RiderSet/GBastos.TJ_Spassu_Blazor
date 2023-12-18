using Domain.Entities;

namespace Manager.Interfaces.Livros
{
    public interface ILivroManager
    {
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
        Task<Livro> InsertLivroAsync(Livro livro);
        Task<Livro> UpdateLivroAsync(Livro livro);
        Task DeleteLivroAsync(int codl);
    }
}
