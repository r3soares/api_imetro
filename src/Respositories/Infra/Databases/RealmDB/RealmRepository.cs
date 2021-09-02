using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class RealmRepository<T> where T : RealmObject
    {
        private readonly RealmDatabase _database;
        public RealmRepository(RealmDatabase database)
        {
            _database = database;
        }
    }
}
