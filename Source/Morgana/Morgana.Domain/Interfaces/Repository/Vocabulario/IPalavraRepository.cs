using Morgana.Domain.Entities.Vocabulario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Domain.Interfaces.Repository.Vocabulario
{
    public interface IPalavraRepository
    {
        Task<IEnumerable<Palavra>> GetAll();
    }
}
