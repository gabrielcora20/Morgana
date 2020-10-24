using System;

namespace Morgana.Infra.Data.MongoDbModule.Context
{
    public class MorganaContext : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
