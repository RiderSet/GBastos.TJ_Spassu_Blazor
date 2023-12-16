using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra_Data.Context
{
    public class CTX : DbContext
    {
        public CTX(DbContextOptions<CTX> options): base(options)
        {
                
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }
    }
}
