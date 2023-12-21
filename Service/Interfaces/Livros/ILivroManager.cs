using Domain.Entities;
using Domain.ViewModel;

namespace Manager.Interfaces.Livros
{
    public interface ILivroManager
    {
        Task<LivroVM> DeleteLivroAsync(int codl);
        Task<IEnumerable<LivroVM>> GetLivroAsync(int codl);
        Task<IEnumerable<Livro>> GetLivrosAsync();
        Task<LivroVM> InsertLivroAsync(CreateLivroVM novoLivro);
        Task<LivroVM> UpdateLivroAsync(UpDateLivroVM alteraLivro);
    }
}
