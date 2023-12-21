using Domain.Entities;
using FluentValidation;
using System.Runtime.CompilerServices;

namespace Manager.Validation
{
    public class LivroValidator : AbstractValidator<Livro>
    {
        public LivroValidator()
        {
            RuleFor(x => x.Titulo).NotNull().MinimumLength(2).MaximumLength(200);
            RuleFor(x => x.Editora).NotNull().MinimumLength(2).MaximumLength(200);
            RuleFor(x => x.Edicao).NotNull().NotEmpty().Must(Edicao_Zero).WithMessage("Deve ser maior do que 0.");
            RuleFor(x => x.AnoPublicacao).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-100));
        }

        private bool Edicao_Zero(int ed)
        {
            if (ed > 0) 
            {
                return true;
            }
            return false;
        }
    }
}
