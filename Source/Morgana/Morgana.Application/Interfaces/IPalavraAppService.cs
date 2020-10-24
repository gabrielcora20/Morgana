using Morgana.Application.ViewModels.Vocabulario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Application.Interfaces
{
    public interface IPalavraAppService
    {
        Task<IEnumerable<PalavraViewModel>> ConsultaPalavras();
    }
}
