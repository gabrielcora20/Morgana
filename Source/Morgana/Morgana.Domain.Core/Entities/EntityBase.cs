using MongoDB.Bson.Serialization.Attributes;

namespace Morgana.Domain.Core.Entities
{
    public class EntityBase
    {
        [BsonId]
        public string _id { get; set; }
    }
}
