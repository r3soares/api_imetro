using Realms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class RealmDatabase : IDatabase
    {
        public IConnection Connection { get; init; }

        private readonly RealmConfiguration _configuration;
        protected Realm Database => Realm.GetInstance(_configuration);

        public RealmDatabase(String databaseName, String location = "Databases")
        {
            var locationDatabase = Path.Combine(Directory.GetCurrentDirectory(), location, databaseName);
            Connection = new RealmConnection(locationDatabase);
            _configuration = new RealmConfiguration(Connection.ConnectionString);
        }
    }
}
