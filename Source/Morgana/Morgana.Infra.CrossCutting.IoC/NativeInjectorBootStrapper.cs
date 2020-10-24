using Microsoft.Extensions.DependencyInjection;
using Morgana.Application.Interfaces;
using Morgana.Application.Services.Vocabulario;
using Morgana.Domain.Interfaces.Events;
using Morgana.Domain.Interfaces.Repository.EventStore;
using Morgana.Domain.Interfaces.Repository.Vocabulario;
using Morgana.Infra.CrossCutting.Bus;
using Morgana.Infra.Data.MongoDbModule.EventSourcing;
using Morgana.Infra.Data.MongoDbModule.Repository.EventSourcing;
using Morgana.Infra.Data.MongoDbModule.Repository.Vocabulario;
using NetDevPack.Mediator;

namespace Morgana.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus(Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Application
            services.AddScoped<IPalavraAppService, PalavraAppService>();

            // Domain - Events
            //services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            //services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, ValidationResult>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, ValidationResult>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, ValidationResult>, CustomerCommandHandler>();

            // Infra - Data
            //services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IPalavraRepository, PalavraRepository>();
            services.AddScoped<Data.MongoDbModule.Context.MorganaContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreMongoDbRepository>();
            services.AddScoped<IEventStore, MongoDbEventStore>();
            //services.AddScoped<EventStoreSqlContext>();
        }
    }
}
