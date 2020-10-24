using Morgana.Application.ViewModels.Vocabulario;
using Morgana.Domain.Entities.Vocabulario;
using AutoMapper;

namespace Morgana.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Palavra, PalavraViewModel>();
        }
    }
}
