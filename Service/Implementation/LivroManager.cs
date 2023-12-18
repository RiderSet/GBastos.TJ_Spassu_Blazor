using Domain.Entities;
using Manager.Interfaces.Livros;

namespace Manager.Implementation
{
    public class LivroManager: ILivroManager
    {
        private readonly ILivroRepository _livroRepository;

        public LivroManager(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<Livro> GetLivroAsync(int codl)
        {
            return await _livroRepository.GetLivroAsync(codl);
        }

        public async Task<IEnumerable<Livro>> GetLivrosAsync()
        {
            return await _livroRepository.GetLivrosAsync();
        }

        public async Task<Livro> InsertLivroAsync(Livro livro)
        {
            return await _livroRepository.InsertLivroAsync(livro);
        }

        public async Task<Livro> UpdateLivroAsync(Livro livro)
        {
            return await _livroRepository.UpdateLivroAsync(livro);
        }

        public async Task DeleteLivroAsync(int codl)
        {
            await _livroRepository.DeleteLivroAsync(codl);
        }
    }
}
