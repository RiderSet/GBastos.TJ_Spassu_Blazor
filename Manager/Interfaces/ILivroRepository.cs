using Domain.Entities;

namespace Manager.Interfaces
{
    public interface ILivroRepository
    {
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
    }
}
