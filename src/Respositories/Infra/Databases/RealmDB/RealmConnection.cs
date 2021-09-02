using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class RealmConnection : IConnection
    {
        public string ConnectionString { get; init; }

        public RealmConnection(String database)
        {
            ConnectionString = database;
        }
    }
}
