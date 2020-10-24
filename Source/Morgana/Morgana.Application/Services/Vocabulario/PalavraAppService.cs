using AutoMapper;
using Morgana.Application.Interfaces;
using Morgana.Application.ViewModels.Vocabulario;
using Morgana.Domain.Interfaces.Repository.Vocabulario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Application.Services.Vocabulario
{
    public class PalavraAppService : IPalavraAppService
    {
        public IPalavraRepository _palavraRepository { get; set; }
        public IMapper _mapper { get; set; }

        public PalavraAppService(IPalavraRepository palavraRepository, IMapper mapper)
        {
            _palavraRepository = palavraRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PalavraViewModel>> ConsultaPalavras()
        {
            return _mapper.Map<IEnumerable<PalavraViewModel>>(await _palavraRepository.GetAll());
        }
    }
}
