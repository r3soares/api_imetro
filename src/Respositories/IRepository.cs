using Realms;
using src.Respositories.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Respositories
{
    public interface IRepository<T>
    { 
        public T GetById(object id);
        public IList<T> GetAll();
        public object Save(T data);
        public object Update(T data);
        public object Delete(object id);
    }
}
