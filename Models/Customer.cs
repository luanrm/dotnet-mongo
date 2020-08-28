using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dotnet_mongo.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string external_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public List<Document> documents { get; set; }
        public List<string> phone_numbers { get; set; }
        public string birthday { get; set; }

    }
}
