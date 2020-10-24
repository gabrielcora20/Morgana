using Morgana.Domain.Events;
using Morgana.Domain.Interfaces.Repository.EventStore;
using Morgana.Infra.Data.MongoDbModule.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Morgana.Infra.Data.MongoDbModule.Repository.EventSourcing
{
    public class EventStoreMongoDbRepository : IEventStoreRepository
    {
        private readonly MorganaContext _context;

        public EventStoreMongoDbRepository(MorganaContext context)
        {
            _context = context;
        }

        public async Task<IList<StoredEvent>> All(Guid aggregateId)
        {
            throw new NotImplementedException();
            //return await (from e in _context.StoredEvent where e.AggregateId == aggregateId select e).ToListAsync();
        }

        public void Store(StoredEvent theEvent)
        {
            //_context.StoredEvent.Add(theEvent);
            //_context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
