using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PracticalApplication.Domain.Customer
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        [BsonElement("id")]
        public Guid Id { get; set; }
    }
}
