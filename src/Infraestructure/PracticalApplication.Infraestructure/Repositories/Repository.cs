using MongoDB.Driver;
using PracticalApplication.Domain.Customer;
using PracticalApplication.Domain.Interfaces;
using System.Numerics;

namespace PracticalApplication.Infraestructure.Repositories
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<CustomerPolicy> _collection;

        public Repository(IMongoDatabase database)
        {
            _collection = database.GetCollection<CustomerPolicy>("Customers");
        }

        public async Task<CustomerPolicy> GetByIdAsync(string id, string placa)
        {
            var filterEmpty = Builders<CustomerPolicy>.Filter.Empty;

            var filter = Builders<CustomerPolicy>.Filter.Or(
                 !string.IsNullOrEmpty(id)?
                   Builders<CustomerPolicy>.Filter.Eq(c => c.Id,Guid.Parse( id)): filterEmpty,
                 !string.IsNullOrEmpty(placa) ?
                   Builders<CustomerPolicy>.Filter.Eq(c => c.PlacaAutomotor, placa): filterEmpty
               );

            return await _collection.Find(filter).FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<CustomerPolicy>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task AddAsync(CustomerPolicy customer)
        {
            await _collection.InsertOneAsync(customer);
        }

        public async Task UpdateAsync(CustomerPolicy customer)
        {
            var filter = Builders<CustomerPolicy>.Filter.Eq(c => c.Id, customer.Id);
            await _collection.ReplaceOneAsync(filter, customer);
        }

        public async Task DeleteAsync(CustomerPolicy customer)
        {
            var filter = Builders<CustomerPolicy>.Filter.Eq(c => c.Id, customer.Id);
            await _collection.DeleteOneAsync(filter);
        }
    }

}
