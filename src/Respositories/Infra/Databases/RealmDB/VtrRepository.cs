using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class VtrRepository<T> : RealmRepository<T> where T : RealmObject
    {
        public VtrRepository() : base("vtr.realm", false) { }
    }
}
