using AutoMapper;
using Morgana.Application.ViewModels.Vocabulario;
using Morgana.Domain.Entities.Vocabulario;

namespace Morgana.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PalavraViewModel, Palavra>();
            //CreateMap<CustomerViewModel, RegisterNewCustomerCommand>()
            //    .ConstructUsing(c => new RegisterNewCustomerCommand(c.Name, c.Email, c.BirthDate));
            //CreateMap<CustomerViewModel, UpdateCustomerCommand>()
            //    .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.Name, c.Email, c.BirthDate));
        }
    }
}
