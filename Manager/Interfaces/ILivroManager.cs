using Domain.Entities;

namespace Manager.Interfaces
{
    public interface ILivroManager
    {
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
    }
}
