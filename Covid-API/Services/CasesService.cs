using Covid_API.Models;
using Covid_API.Models.MongoDB;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Covid_API.Services
{
    public class CasesService
    {
        private readonly IMongoCollection<Cases> _cases;

        public CasesService(IMongoConnectionSettings settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase dataBase = client.GetDatabase(settings.DataBaseName);
            _cases = dataBase.GetCollection<Cases>(settings.CasesCollectionName);
        }

        public List<Cases> Get() => _cases.Find(_ => true).ToList();
    }
}
