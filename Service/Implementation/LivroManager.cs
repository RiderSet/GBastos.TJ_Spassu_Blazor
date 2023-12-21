using AutoMapper;
using Domain.Entities;
using Domain.ViewModel;
using Manager.Interfaces.Livros;
using Microsoft.Extensions.Logging;

namespace Manager.Implementation
{
    public class LivroManager: ILivroManager
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IMapper mapper;
        private readonly ILogger<LivroManager> logger;

        public LivroManager(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
            mapper = mapper;
            logger = logger;
        }

        public async Task<IEnumerable<LivroVM>> GetLivroAsync(int codl)
        {
            var livros = await _livroRepository.GetLivrosAsync();
            return mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVM>>(livros);
        }

        public async Task<IEnumerable<Livro>> GetLivrosAsync()
        {
           // return await _livroRepository.GetLivrosAsync();
            var livros = await _livroRepository.GetLivrosAsync();
            return mapper.Map<IEnumerable<Livro>, IEnumerable<Livro>>(livros);
        }

        public async Task<LivroVM> DeleteLivroAsync(int codl)
        {
            var livro = await _livroRepository.GetLivroAsync(codl);
            return mapper.Map<LivroVM>(livro);
        }

        public async Task<LivroVM> InsertLivroAsync(CreateLivroVM novoLivro)
        {
          //logger.LogInformation("Chamada de negócio para inserir um cliente.");
            var livro = mapper.Map<Livro>(novoLivro);
            livro = await _livroRepository.InsertLivroAsync(livro);
            return mapper.Map<LivroVM>(livro);
        }

        public async Task<LivroVM> UpdateLivroAsync(UpDateLivroVM alteraLivro)
        {
            var livro = mapper.Map<Livro>(alteraLivro);
            livro = await _livroRepository.UpdateLivroAsync(livro);
            return mapper.Map<LivroVM>(livro);
        }
    }
}
