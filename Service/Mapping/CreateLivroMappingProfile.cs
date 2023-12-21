using AutoMapper;
using Domain.Entities;
using Domain.ViewModel;

namespace Manager.Mapping
{
    public class CreateLivroMappingProfile : Profile
    {
        public CreateLivroMappingProfile()
        {
            CreateMap<CreateLivroVM, Livro>()
                .ForMember(d => d.AnoPublicacao, o => o.MapFrom(x => x.AnoPublicacao));

            CreateMap<Livro, LivroVM>();
        }
    }
}
