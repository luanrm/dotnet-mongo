using System.Collections.Generic;
using MongoDB.Driver;
using dotnet_mongo.Models;

namespace dotnet_mongo.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customer;

        public CustomerService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _customer = database.GetCollection<Customer>(settings.Customer);
        }

        public List<Customer> Get() =>
            _customer.Find(customer => true).ToList();

        public Customer Get(string id) =>
            _customer.Find<Customer>(customer => customer.id == id).FirstOrDefault();

        public Customer Create(Customer customer)
        {
            _customer.InsertOne(customer);
            return customer;
        }

        public void Update(string id, Customer customerIn) =>
            _customer.ReplaceOne(book => book.id == id, customerIn);

        public void Remove(Customer customer) =>
            _customer.DeleteOne(customer => customer.id == customer.id);

        public void Remove(string id) => 
            _customer.DeleteOne(customer => customer.id == id);
    }
}