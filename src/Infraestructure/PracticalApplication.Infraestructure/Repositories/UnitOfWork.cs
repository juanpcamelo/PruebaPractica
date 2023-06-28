using MongoDB.Driver;
using PracticalApplication.Domain.Interfaces;
using PracticalApplication.Infraestructure.Interfaces;

namespace PracticalApplication.Infraestructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoDatabase _database;
        private readonly IRepository _customerRepository;

        public UnitOfWork(IMongoDatabase database)
        {
            _database = database;
        }
        public IRepository CustomerRepository => _customerRepository ?? new Repository(_database);

        public async Task<int> SaveChangesAsync()
        {
            return await Task.FromResult(0);
        }
    }

}



