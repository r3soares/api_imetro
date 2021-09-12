using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories.Infra.Databases.RealmDB
{
    public class VtrRepository<T> : IVtrRepository<T>
        where T : RealmObject 
    {
        static readonly bool PERSISTENCIA_BANCO = false;
        private IRepository<T> _repository;
        public VtrRepository()
        {
            _repository = new RealmDatabase<T>("vtr.realm", PERSISTENCIA_BANCO);
        }

        public object Delete(object id)
        {
            return _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public object Save(T data)
        {
            return _repository.Save(data);
        }

        public object Update(T data)
        {
            return _repository.Update(data);
        }
    }
}
