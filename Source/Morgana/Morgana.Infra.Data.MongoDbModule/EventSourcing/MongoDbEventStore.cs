using Morgana.Domain.Events;
using Morgana.Domain.Interfaces.Events;
using Morgana.Domain.Interfaces.Repository.EventStore;
using NetDevPack.Identity.User;
using NetDevPack.Messaging;
using Newtonsoft.Json;

namespace Morgana.Infra.Data.MongoDbModule.EventSourcing
{

    public class MongoDbEventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IAspNetUser _user;

        public MongoDbEventStore(IEventStoreRepository eventStoreRepository, IAspNetUser user)
        {
            _eventStoreRepository = eventStoreRepository;
            _user = user;
        }
        public void Save<T>(T theEvent) where T : Event
        {
            // Using Newtonsoft.Json because System.Text.Json
            // is a sad joke and far to be considered "Done"
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(
                theEvent,
                serializedData,
                _user.Name ?? _user.GetUserEmail());

            _eventStoreRepository.Store(storedEvent);
        }
    }
}
