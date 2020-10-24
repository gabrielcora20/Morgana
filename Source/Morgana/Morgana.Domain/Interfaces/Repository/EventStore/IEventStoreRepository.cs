using Morgana.Domain.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Domain.Interfaces.Repository.EventStore
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        Task<IList<StoredEvent>> All(Guid aggregateId);
    }
}
