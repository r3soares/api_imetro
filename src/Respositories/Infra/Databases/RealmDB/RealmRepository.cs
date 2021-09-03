using Realms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public abstract class RealmRepository<T> : IRepository<T>
        where T : RealmObject
        
    {
        private RealmConfigurationBase _configuration;
        private Realm Database => Realm.GetInstance(_configuration);
        public RealmRepository(string databaseName, bool persist = true)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Databases", databaseName);
            _configuration = persist ? new RealmConfiguration(path) : new InMemoryConfiguration(path);
        }

        public object Delete(object id)
        {
            var data = GetById(id);
            try
            {
                Database.Remove(data);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public IList<T> GetAll()
        {
            return Database.All<T>().ToList();
        }

        public T GetById(object id) => id switch
        {
            long d      => Database.Find<T>(d),
            int d       => Database.Find<T>(d),
            string d    => Database.Find<T>(d),
            Guid d      => Database.Find<T>(d),
            _ => null
        };

        public object Save(T data)
        {
            var realm = Database;
            try
            {
                realm.Write(() => realm.Add(data, false));
                return true;
            }
            catch
            {

                return false;
            }
            
        }

        public object Update(T data)
        {
            var realm = Database;
            try
            {
                realm.Write(() => realm.Add(data, true));
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
