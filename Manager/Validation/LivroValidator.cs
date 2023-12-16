using Domain.Entities;
using FluentValidation;

namespace Manager.Validation
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(t => t.Titulo).NotEmpty().MinimumLength(1).MaximumLength(200);
            RuleFor(t => t.Editora).NotEmpty().MaximumLength(200);
            RuleFor(t => t.Edicao).GreaterThan(0);
            RuleFor(t => t.AnoPublicacao).NotEmpty();
        }
    }
}
