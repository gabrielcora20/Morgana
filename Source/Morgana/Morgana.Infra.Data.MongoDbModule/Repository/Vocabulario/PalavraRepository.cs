using Morgana.Domain.Entities.Vocabulario;
using Morgana.Domain.Interfaces.Repository.Vocabulario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Infra.Data.MongoDbModule.Repository.Vocabulario
{
    public class PalavraRepository : IPalavraRepository
    {
        public async Task<IEnumerable<Palavra>> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
