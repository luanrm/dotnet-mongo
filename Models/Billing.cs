using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_mongo.Models
{
    public class Billing
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public Address address { get; set; }

    }
}
