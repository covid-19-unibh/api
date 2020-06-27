using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_API.Models
{
    public class MongoConnectionSettings : IMongoConnectionSettings
    {
        public string CasesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }

    public interface IMongoConnectionSettings
    {
        string CasesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}
