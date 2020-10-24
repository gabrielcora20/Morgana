using NetDevPack.Messaging;

namespace Morgana.Domain.Interfaces.Events
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
