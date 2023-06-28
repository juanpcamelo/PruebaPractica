using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using PracticalApplication.Domain.Interfaces;
using PracticalApplication.Infraestructure.Interfaces;
using PracticalApplication.Infraestructure.Repositories;

namespace PracticalApplication.Infraestructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContextInfra(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = "mongodb+srv://Customer:A1B2C3B4@atlascluster.zysnbor.mongodb.net/";
            var databaseName = "MongoDbDatabase";

            services.AddSingleton<IMongoClient>(x => new MongoClient(connectionString));
            services.AddScoped<IMongoDatabase>(x => x.GetRequiredService<IMongoClient>().GetDatabase(databaseName));

            return services;
        }

        public static IServiceCollection AddServicesInfra(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository),typeof(Repository));

            return services;
        }
    }
}
