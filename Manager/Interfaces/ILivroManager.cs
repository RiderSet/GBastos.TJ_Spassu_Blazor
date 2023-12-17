using Domain.Entities;

namespace Manager.Interfaces
{
    public interface ILivroManager
    {
<<<<<<< HEAD
        Task DeleteLivroAsync(int codl);

        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();

        Task<Livro> InsertLivroAsync(Livro livro);
        Task<Livro> UpdateLivroAsync(Livro livro);
=======
        Task<Livro> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
>>>>>>> 51c3c4458ceaaa5b25419d46fb08c636033c7f4f
    }
}
