using Domain.Entities;
using Infra_Data.Context;
using Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {

        private readonly CTX _context;

        public LivroRepository(CTX context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetLivrosAsync()
        {
            return await _context.Livros.AsNoTracking().ToListAsync();
        }

        public async Task<Livro> GetLivroAsync(int codl)
        {
            return await _context.Livros.FindAsync(codl);
        }

        public async Task<Livro> InsertLivroAsync(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
            return livro;
        }

        public async Task<Livro> UpdateLivroAsync(Livro livro)
        {
            var livroConsultado = await _context.Livros.FindAsync(livro.Codl);

            if (livroConsultado == null)
            {
                return null;
            }

            _context.Entry(livroConsultado).CurrentValues.SetValues(livro);
            _context.Livros.Update(livroConsultado);
            await _context.SaveChangesAsync();
            return livroConsultado;
        }
    }
}
