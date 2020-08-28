using System.Collections.Generic;
using MongoDB.Driver;
using dotnet_mongo.Models;

namespace dotnet_mongo.Services
{
    public class BillingService
    {
        private readonly IMongoCollection<Billing> _billing;

        public BillingService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _billing = database.GetCollection<Billing>(settings.Billing);
        }

        public List<Billing> Get() =>
            _billing.Find(billing => true).ToList();

        public Billing Get(string id) =>
            _billing.Find<Billing>(billing => billing.id == id).FirstOrDefault();

        public Billing Create(Billing billing)
        {
            _billing.InsertOne(billing);
            return billing;
        }

        public void Update(string id, Billing billingIn) =>
            _billing.ReplaceOne(book => book.id == id, billingIn);

        public void Remove(Billing billing) =>
            _billing.DeleteOne(billing => billing.id == billing.id);

        public void Remove(string id) => 
            _billing.DeleteOne(billing => billing.id == id);
    }
}