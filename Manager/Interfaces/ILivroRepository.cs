using Domain.Entities;

namespace Manager.Interfaces
{
    public interface ILivroRepository
    {
        Task DeleteLivroAsync(int codl);

        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();

        Task<Livro> InsertLivroAsync(Livro livro);
        Task<Livro> UpdateLivroAsync(Livro livro);
    }
}
