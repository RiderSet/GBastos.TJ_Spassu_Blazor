using Domain.Entities;
using Infra_Data.Context;
using Manager.Interfaces.Livros;
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
            //return await _context.Livros.AsNoTracking().ToListAsync();
            return await _context.Livros
                .Include(p => p.Assuntos)
                .Include(p => p.Autores)
                .AsNoTracking().ToListAsync();
        }

        public async Task<Livro> GetLivroAsync(int codl)
        {
            //return await _context.Livros.FindAsync(codl);
            return await _context.Livros
                .Include(p => p.Assuntos)
                .Include(p => p.Autores)
                .SingleOrDefaultAsync(p => p.Codl == codl);
        }

        public async Task<Livro> InsertLivroAsync(Livro Livro)
        {
            await _context.Livros.AddAsync(Livro);
            await _context.SaveChangesAsync();
            return Livro;
        }

        public async Task<Livro> UpdateLivroAsync(Livro Livro)
        {
            var livroConsultado = await _context.Livros.FindAsync(Livro.Codl);

            if (livroConsultado == null)
            {
                return null;
            }

            _context.Entry(livroConsultado).CurrentValues.SetValues(Livro);
            _context.Livros.Update(livroConsultado);
            await _context.SaveChangesAsync();
            return livroConsultado;
        }

        public async Task<Livro> DeleteLivroAsync(int codl)
        {
            /*
            var livroConsultado = await _context.Livros.FindAsync(codl);
            _context.Livros.Remove(livroConsultado);
            await _context.SaveChangesAsync();
            */
            var livroConsultado = await _context.Livros.FindAsync(codl);
            if (livroConsultado == null)
            {
                return null;
            }
            var livroRemovido = _context.Livros.Remove(livroConsultado);
            await _context.SaveChangesAsync();
            return livroRemovido.Entity;

        }
    }
}
